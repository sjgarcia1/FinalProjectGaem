using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CYC : MonoBehaviour
{
    public GameObject BarrelMan;
    public GameObject BucketMan;
    public GameObject CrateMan;
    public GameObject PorpleGuy;
    public GameObject Pedro;
    public GameObject Arrow;
    public GameObject LittleE;
    public GameObject Enemy;
    public GameObject Archer;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            GameObject BarrelManInstance = Instantiate(BarrelMan, transform.position, transform.rotation);
            PorpleGuy.GetComponent<PorplGuy>().chosebarrelman = true;
            Pedro.GetComponent<Pedro>().chosebarrelman = true;
            Arrow.GetComponent<Arrow>().chosebarrelman = true;
            LittleE.GetComponent<LittleE>().chosebarrelman = true;
            Enemy.GetComponent<ES>().chosebarrelman = true;
            Archer.GetComponent<Archer>().chosebarrelman = true;
            Destroy(this.gameObject);
        }

        if (Input.GetKey(KeyCode.B) || Input.GetKey(KeyCode.RightArrow))
        {
            GameObject BucketManInstance = Instantiate(BucketMan, transform.position, transform.rotation);
            PorpleGuy.GetComponent<PorplGuy>().chosebucketman = true;
            Pedro.GetComponent<Pedro>().chosebucketman = true;
            Arrow.GetComponent<Arrow>().chosebucketman = true;
            LittleE.GetComponent<LittleE>().chosebucketman = true;
            Enemy.GetComponent<ES>().chosebucketman = true;
            Archer.GetComponent<Archer>().chosebucketman = true;
            Destroy(this.gameObject);
        }

        if (Input.GetKey(KeyCode.C) || Input.GetKey(KeyCode.LeftArrow))
        {
            GameObject CrateInstance = Instantiate(CrateMan, transform.position, transform.rotation);
            PorpleGuy.GetComponent<PorplGuy>().chosecrateman = true;
            Pedro.GetComponent<Pedro>().chosecrateman = true;
            Arrow.GetComponent<Arrow>().chosecrateman = true;
            LittleE.GetComponent<LittleE>().chosecrateman = true;
            Enemy.GetComponent<ES>().chosecrateman = true;
            Archer.GetComponent<Archer>().chosecrateman = true;
            Destroy(this.gameObject);
        }
    }
}
