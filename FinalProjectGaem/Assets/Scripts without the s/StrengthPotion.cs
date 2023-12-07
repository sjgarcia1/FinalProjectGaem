using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthPotion : MonoBehaviour
{
    public bool exists = true;
    public GameObject gun;

    private void Update()
    {
        if (exists == false)
        {
            Destroy(this.gameObject);

        }
    }
}
