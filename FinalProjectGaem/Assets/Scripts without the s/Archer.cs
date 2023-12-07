using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    public float speed;
    private float startingX;
    public int EHP = 3;
    public GameObject BarrelMan;
    public GameObject BucketMan;
    public GameObject CrateMan;
    public float posx;
    public float posz;
    public GameObject Arrow;
    public bool chosebarrelman = false;
    public bool chosebucketman = false;
    public bool chosecrateman = false;
    void Start()
    {
        startingX = transform.position.x;
        //StartCoroutine(ArrowSpawn());
    }


    void Update()
    {
        posx = transform.position.x;
        posz = transform.position.z;

        if (chosebarrelman == true)
        {
            if (BarrelMan == null) BarrelMan = GameObject.FindFirstObjectByType<PC2>().gameObject;
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

        if (chosebucketman == true)
        {
            if (BucketMan == null) BucketMan = GameObject.FindFirstObjectByType<PC2>().gameObject;
            if (posx <= BucketMan.GetComponent<PC2>().posx && posz <= BucketMan.GetComponent<PC2>().posz)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                transform.position += Vector3.forward * speed * Time.deltaTime;
            }

            if (posx <= BucketMan.GetComponent<PC2>().posx && posz >= BucketMan.GetComponent<PC2>().posz)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                transform.position += Vector3.back * speed * Time.deltaTime;
            }

            if (posx >= BucketMan.GetComponent<PC2>().posx && posz <= BucketMan.GetComponent<PC2>().posz)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                transform.position += Vector3.forward * speed * Time.deltaTime;
            }

            if (posx >= BucketMan.GetComponent<PC2>().posx && posz >= BucketMan.GetComponent<PC2>().posz)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                transform.position += Vector3.back * speed * Time.deltaTime;
            }
        }

        if (chosecrateman == true)
        {
            if (CrateMan == null) CrateMan = GameObject.FindFirstObjectByType<PC2>().gameObject;
            if (posx <= CrateMan.GetComponent<PC2>().posx && posz <= CrateMan.GetComponent<PC2>().posz)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                transform.position += Vector3.forward * speed * Time.deltaTime;
            }

            if (posx <= CrateMan.GetComponent<PC2>().posx && posz >= CrateMan.GetComponent<PC2>().posz)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                transform.position += Vector3.back * speed * Time.deltaTime;
            }

            if (posx >= CrateMan.GetComponent<PC2>().posx && posz <= CrateMan.GetComponent<PC2>().posz)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                transform.position += Vector3.forward * speed * Time.deltaTime;
            }

            if (posx >= CrateMan.GetComponent<PC2>().posx && posz >= CrateMan.GetComponent<PC2>().posz)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                transform.position += Vector3.back * speed * Time.deltaTime;
            }
        }

        if (EHP <= 0)
        {
            Destroy(this.gameObject);
            
        }

        
        
    }

    IEnumerator ArrowSpawn()
    {
        GameObject ArrowInstance = Instantiate(Arrow, transform.position, transform.rotation);
        yield return new WaitForSeconds(1f);
        StartCoroutine(ArrowSpawn());
    }

}
