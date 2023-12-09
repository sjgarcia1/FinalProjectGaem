using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StrengthPotion1 : MonoBehaviour
{
    public bool exists = true;
    public GameObject gun;
    public bool chosebarrelman = false;
    public bool chosebucketman = false;
    public bool chosecrateman = false;

    private void Update()
    {
        if (chosebarrelman == true)
        {
            if (gun == null)
            {
                gun = GameObject.FindFirstObjectByType<Gun>().gameObject;
            }

            if (exists == false)
            {
                Destroy(this.gameObject);
                gun.GetComponent<Gun>().start = true;
            }
        }

        if (chosebucketman == true)
        {
            if (gun == null)
            {
                gun = GameObject.FindFirstObjectByType<Sword>().gameObject;
            }

            
                Destroy(this.gameObject);
                
            
        }

        if (chosecrateman == true)
        {
            if (gun == null)
            {
                gun = GameObject.FindFirstObjectByType<Hammer>().gameObject;
            }

            Destroy(this.gameObject);
        }

    }
}
