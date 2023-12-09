using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.SceneManagement;

public class PC2 : MonoBehaviour
{
    public float speed = 10f;
    public int health = 100;
    public int maxhealth = 100;
    public float posx;
    public float posz;
    public bool vulnerable = true;
    public GameObject gun;

    void Start()
    {
    }


    void Update()
    {

        posx = transform.position.x;
        posz = transform.position.z;

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

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("rightClick");
            transform.Rotate(Vector3.up * 90);


        }

        if (health <= 0)
        {
            Debug.Log("You got dead");
            SceneManager.LoadScene(2);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HealthPotion" && health < maxhealth)
        {
            Debug.Log ("you collided with me ree");
            other.gameObject.GetComponent<HP>().exists = false;
            health = health + 25;
        }

        if (other.gameObject.tag == "SwiftnessPotion")
        {
            StartCoroutine(SpeedUp());
            other.gameObject.GetComponent<SwiftnessPotion>().exists = false;
        }

        if (other.gameObject.tag == "StrengthPotion")
        {
            gun.GetComponent<Gun>().start = true;
            other.gameObject.GetComponent<StrengthPotion>().exists = false;
           
        }

        if (other.gameObject.tag == "Enemy" && vulnerable == true)
        {
            Debug.Log("you collided with me ree");
            health = health - 10;
            StartCoroutine(CanHurt());
            StartCoroutine(Blink());
        }
        if (other.gameObject.tag == "PEnemy" && vulnerable == true)
        {
            Debug.Log("you collided with me ree");
            health = health - 10;
            StartCoroutine(CanHurt());
            StartCoroutine(Blink());
        }
        if (other.gameObject.tag == "LittleE" && vulnerable == true)
        {
            Debug.Log("you collided with me ree");
            health = health - 10;
            StartCoroutine(CanHurt());
            StartCoroutine(Blink());
        }
        if (other.gameObject.tag == "Spikes" && vulnerable == true)
        {
            Debug.Log("you collided with me ree");
            health = health - 10;
            StartCoroutine(CanHurt());
            StartCoroutine(Blink());
        }
        if (other.gameObject.tag == "Pedro" && vulnerable == true)
        {
            Debug.Log("you collided with me ree");
            health = health - 10;
            StartCoroutine(CanHurt());
            StartCoroutine(Blink());
        }
        if (other.gameObject.tag == "Archer" && vulnerable == true)
        {
            Debug.Log("you collided with me ree");
            health = health - 5;
            StartCoroutine(CanHurt());
            StartCoroutine(Blink());
        }
        if (other.gameObject.tag == "Arrow" && vulnerable == true)
        {
            Debug.Log("you collided with me ree");
            health = health - 10;
            StartCoroutine(CanHurt());
            StartCoroutine(Blink());
        }

        if (other.gameObject.tag == "Arrow" && vulnerable == true)
        {
            Debug.Log("you collided with me ree");
            health = health - 10;
            StartCoroutine(CanHurt());
            StartCoroutine(Blink());
        }

        IEnumerator CanHurt()
        {
            vulnerable = false;
            yield return new WaitForSeconds(1f);
            vulnerable = true;

        }

        IEnumerator Blink()
        {
            for (int index = 0; index < 10; index++)
            {
                if (index % 2 == 0)
                {
                    GetComponent<MeshRenderer>().enabled = false;
                }
                else
                {
                    GetComponent<MeshRenderer>().enabled = true;
                }
                yield return new WaitForSeconds(.1f);
            }
            GetComponent<MeshRenderer>().enabled = true;
        }

        IEnumerator SpeedUp()
        {
            speed = 20f;
            yield return new WaitForSeconds(5f);
            speed = 10f;

        }
    }
}
