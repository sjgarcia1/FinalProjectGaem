using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
   

    void Start()
    {
        StartCoroutine(DespawnDelay());
    }
    void Update()
    {

        
            transform.position += -transform.right * speed * Time.deltaTime;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Destroy(this.gameObject);
            other.gameObject.GetComponent<ES>(). EHP--;
        }
       


    }

    IEnumerator DespawnDelay()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);

    }
}

