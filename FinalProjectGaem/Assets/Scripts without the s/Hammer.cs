using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public bool CanShoot = true;
    public bool supermode = false;
    public bool start = false;
    public Animation CrateHammer;
    public bool CanHurt = false;
    public GameObject Hammerman;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && CanShoot == true && supermode == false)
        {

            StartCoroutine(HammerCoolDown());
            CrateHammer.Play("CrateHammer");
            StartCoroutine(KillTiem());
        }

        if (Input.GetMouseButton(0) && CanShoot == true && supermode == true)
        {
            StartCoroutine(HammerCoolDown());
            CrateHammer.Play("Cratehammer");
            StartCoroutine(KillTiem());

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
                other.gameObject.GetComponent<ES>().EHP--;
                other.gameObject.GetComponent<ES>().EHP--;
                other.gameObject.GetComponent<ES>().EHP--;
                other.gameObject.GetComponent<ES>().EHP--;
                other.gameObject.GetComponent<ES>().EHP--;
                other.gameObject.GetComponent<ES>().EHP--;
                other.gameObject.GetComponent<ES>().EHP--;

            }

            if (other.gameObject.tag == "PEnemy")
            {


                other.gameObject.GetComponent<PorplGuy>().EHP--;
                other.gameObject.GetComponent<PorplGuy>().EHP--;
                other.gameObject.GetComponent<PorplGuy>().EHP--;
                other.gameObject.GetComponent<PorplGuy>().EHP--;
                other.gameObject.GetComponent<PorplGuy>().EHP--;
                other.gameObject.GetComponent<PorplGuy>().EHP--;
                other.gameObject.GetComponent<PorplGuy>().EHP--;
                other.gameObject.GetComponent<PorplGuy>().EHP--;
                other.gameObject.GetComponent<PorplGuy>().EHP--;
            }

            if (other.gameObject.tag == "LittleE")
            {



                other.gameObject.GetComponent<LittleE>().EHP--;
                other.gameObject.GetComponent<LittleE>().EHP--;
                other.gameObject.GetComponent<LittleE>().EHP--;
                other.gameObject.GetComponent<LittleE>().EHP--;
                other.gameObject.GetComponent<LittleE>().EHP--;
                other.gameObject.GetComponent<LittleE>().EHP--;
                other.gameObject.GetComponent<LittleE>().EHP--;
                other.gameObject.GetComponent<LittleE>().EHP--;
                other.gameObject.GetComponent<LittleE>().EHP--;
            }
            if (other.gameObject.tag == "Pedro")
            {


                other.gameObject.GetComponent<Pedro>().REHP--;
                other.gameObject.GetComponent<Pedro>().REHP--;
                other.gameObject.GetComponent<Pedro>().REHP--;
                other.gameObject.GetComponent<Pedro>().REHP--;
                other.gameObject.GetComponent<Pedro>().REHP--;
                other.gameObject.GetComponent<Pedro>().REHP--;
                other.gameObject.GetComponent<Pedro>().REHP--;
                other.gameObject.GetComponent<Pedro>().REHP--;
                other.gameObject.GetComponent<Pedro>().REHP--;
            }
            if (other.gameObject.tag == "Archer")
            {


                other.gameObject.GetComponent<Archer>().EHP--;
                other.gameObject.GetComponent<Archer>().EHP--;
                other.gameObject.GetComponent<Archer>().EHP--;
                other.gameObject.GetComponent<Archer>().EHP--;
                other.gameObject.GetComponent<Archer>().EHP--;
                other.gameObject.GetComponent<Archer>().EHP--;
                other.gameObject.GetComponent<Archer>().EHP--;
                other.gameObject.GetComponent<Archer>().EHP--;
                other.gameObject.GetComponent<Archer>().EHP--;
            }
        }
    }

    IEnumerator HammerCoolDown()
    {
        CanShoot = false;
        yield return new WaitForSeconds(3f);
        CanShoot = true;
    }

    IEnumerator KillTiem()
    {
        Hammerman.GetComponent<PC2>().stun = true;
        CanHurt = true;
        yield return new WaitForSeconds(1.3f);
        CanHurt = false;
        Hammerman.GetComponent<PC2>().stun = false;
    }

    IEnumerator Supermode()
    {
        supermode = true;
        yield return new WaitForSeconds(5f);
        supermode = false;

    }
}
