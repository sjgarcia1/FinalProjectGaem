using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject BarrelMan;
    public float speed;
    private float startingX;
    public float posx;
    public float posz;

    private void Start()
    {
        posx = transform.position.x;
        posz = transform.position.z;

        StartCoroutine(DespawnDelay());


        
    }
    private void Update()
    {
        if (posx <= BarrelMan.GetComponent<PC2>().posx && posz <= BarrelMan.GetComponent<PC2>().posz)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (posx <= BarrelMan.GetComponent<PC2>().posx && posz >= BarrelMan.GetComponent<PC2>().posz)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (posx >= BarrelMan.GetComponent<PC2>().posx && posz <= BarrelMan.GetComponent<PC2>().posz)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (posx >= BarrelMan.GetComponent<PC2>().posx && posz >= BarrelMan.GetComponent<PC2>().posz)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

    }
    IEnumerator DespawnDelay()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);

    }
}
