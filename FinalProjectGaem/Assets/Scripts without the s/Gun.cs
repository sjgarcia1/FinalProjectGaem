using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    public bool CanShoot = true;
    public bool supermode = false;
    public bool start = false;
    public Animation GunShoot;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && CanShoot == true && supermode == false)
        {
            GameObject BooletInstance = Instantiate(Bullet, transform.position, transform.rotation);
            StartCoroutine(BooletCoolDown());
            GunShoot.Play("gunShot");
        }

        if (Input.GetMouseButton(0) && CanShoot == true && supermode == true)
        {
            GameObject BooletInstance = Instantiate(Bullet, transform.position, transform.rotation);
            StartCoroutine(ShorterCoolDown());
        }

        if (start == true)
        {
            Debug.Log("This is working");
            StartCoroutine(Supermode());
            start = false;
        }
    }

    IEnumerator BooletCoolDown()
    {
        CanShoot = false;
        yield return new WaitForSeconds(1f);
        CanShoot = true;
    }

    IEnumerator ShorterCoolDown()
    {
        CanShoot = false;
        yield return new WaitForSeconds(0.1f);
        CanShoot = true;
    }

    IEnumerator Supermode()
    {
        supermode = true;
        yield return new WaitForSeconds(5f);
        supermode = false;

    }

}
