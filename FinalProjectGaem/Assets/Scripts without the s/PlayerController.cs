using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10f;
    public int health = 100;
    public int maxhealth = 100;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (health >= maxhealth)
        {
            health = maxhealth;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HealthPotion")
        {
            
            
                other.gameObject.GetComponent<HP>().exists = false;
                health = health + 25;
            

        }
    }
}
