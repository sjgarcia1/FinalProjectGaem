using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sword : MonoBehaviour
{
    
    public bool CanShoot = true;
    public bool supermode = false;
    public bool start = false;
    public Animation BucketSword;
    public bool CanHurt = false;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && CanShoot == true && supermode == false)
        {
            
            StartCoroutine(SwordCoolDown());
            BucketSword.Play("BucketSword");
            StartCoroutine(KillTiem());
        }

        if (Input.GetMouseButton(0) && CanShoot == true && supermode == true)
        {
            StartCoroutine(SwordCoolDown());
            BucketSword.Play("BucketSword");
            StartCoroutine(ShorterCoolDown());
        }

        if (start == true)
        {
            Debug.Log("This is working");
            StartCoroutine(Supermode());
            start = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (CanHurt == true)
        {
            if (other.gameObject.tag == "Enemy")
            {
               
                    other.gameObject.GetComponent<ES>().EHP--;
                    other.gameObject.GetComponent<ES>().EHP--;
                
            }

            if (other.gameObject.tag == "PEnemy")
            {

                
                    other.gameObject.GetComponent<PorplGuy>().EHP--;
                    other.gameObject.GetComponent<PorplGuy>().EHP--;
                
            }

            if (other.gameObject.tag == "LittleE")
            {

              
                   
                    other.gameObject.GetComponent<LittleE>().EHP--;
                    other.gameObject.GetComponent<LittleE>().EHP--;
                
            }
            if (other.gameObject.tag == "Pedro")
            {

                
                    other.gameObject.GetComponent<Pedro>().REHP--;
                    other.gameObject.GetComponent<Pedro>().REHP--;
                
            }
            if (other.gameObject.tag == "Archer")
            {

                
                    other.gameObject.GetComponent<Archer>().EHP--;
                    other.gameObject.GetComponent<Archer>().EHP--;
                
            }
        }
    }

    IEnumerator SwordCoolDown()
    {
        CanShoot = false;
        yield return new WaitForSeconds(1.2f);
        CanShoot = true;
    }

    IEnumerator KillTiem()
    {
        CanHurt = true;
        yield return new WaitForSeconds(1.2f);
        CanHurt = false;
    }

    IEnumerator ShorterCoolDown()
    {
        CanShoot = false;
        yield return new WaitForSeconds(0.1f);
        CanShoot = true;
    }

    IEnumerator Supermode()
    {
        supermode = true;
        yield return new WaitForSeconds(5f);
        supermode = false;

    }
}
