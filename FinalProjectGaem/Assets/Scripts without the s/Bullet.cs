using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public bool buff = false;
   

    void Start()
    {
        StartCoroutine(DespawnDelay());
    }
    void Update()
    {

        
            transform.position += -transform.forward * speed * Time.deltaTime;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (buff == false)
            {
                Destroy(this.gameObject);
                other.gameObject.GetComponent<ES>().EHP--;
            }

            if (buff == true)
            {
                Destroy(this.gameObject);
                other.gameObject.GetComponent<ES>().EHP--;
                other.gameObject.GetComponent<ES>().EHP--;
            }
        }

        if (other.gameObject.tag == "PEnemy")
        {

            if (buff == false)
            {
                Destroy(this.gameObject);
                other.gameObject.GetComponent<PorplGuy>().EHP--;
            }

            if (buff == true)
            {
                Destroy(this.gameObject);
                other.gameObject.GetComponent<PorplGuy>().EHP--;
                other.gameObject.GetComponent<PorplGuy>().EHP--;
            }
        }

        if (other.gameObject.tag == "LittleE")
        {

            if (buff == false)
            {
                Destroy(this.gameObject);
                other.gameObject.GetComponent<LittleE>().EHP--;
            }

            if (buff == true)
            {
                Destroy(this.gameObject);
                other.gameObject.GetComponent<LittleE>().EHP--;
                other.gameObject.GetComponent<LittleE>().EHP--;
            }
        }
        if (other.gameObject.tag == "Pedro")
        {

            if (buff == false)
            {
                Destroy(this.gameObject);
                other.gameObject.GetComponent<Pedro>().REHP--;
            }

            if (buff == true)
            {
                Destroy(this.gameObject);
                other.gameObject.GetComponent<Pedro>().REHP--;
                other.gameObject.GetComponent<Pedro>().REHP--;
            }
        }
        if (other.gameObject.tag == "Archer")
        {

            if (buff == false)
            {
                Destroy(this.gameObject);
                other.gameObject.GetComponent<Archer>().EHP--;
            }

            if (buff == true)
            {
                Destroy(this.gameObject);
                other.gameObject.GetComponent<Archer>().EHP--;
                other.gameObject.GetComponent<Archer>().EHP--;
            }
        }


    }

    IEnumerator DespawnDelay()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);

    }
}

