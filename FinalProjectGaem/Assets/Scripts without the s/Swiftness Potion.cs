using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwiftnessPotion : MonoBehaviour
{
    
    public bool exists = true;

    private void Update()
    {
        if (exists == false)
        {
            Destroy(this.gameObject);
        }
    }
}
