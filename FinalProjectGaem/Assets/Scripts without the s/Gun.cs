using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    public bool CanShoot = true;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && CanShoot == true)
        {
            GameObject BooletInstance = Instantiate(Bullet, transform.position, transform.rotation);
            StartCoroutine(BooletCoolDown());
        }
    }

    IEnumerator BooletCoolDown()
    {
        CanShoot = false;
        yield return new WaitForSeconds(1f);
        CanShoot = true;
    }

}
