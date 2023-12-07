using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class ES : MonoBehaviour
{
    public float speed;
    private float startingX;
    public int EHP = 10;
    public GameObject BarrelMan;
    public float posx;
    public float posz;
    void Start()
    {
        startingX = transform.position.x;
    }

  
    void Update()
    {
        posx = transform.position.x;
        posz = transform.position.z;

        if (posx <= BarrelMan.GetComponent<PC2>().posx && posz <= BarrelMan.GetComponent<PC2>().posz)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (posx <= BarrelMan.GetComponent<PC2>().posx && posz >= BarrelMan.GetComponent<PC2>().posz)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.position += Vector3.back* speed * Time.deltaTime;
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

        if (EHP <= 0)
        {
            Destroy(this.gameObject);
        }
    }

 
}
