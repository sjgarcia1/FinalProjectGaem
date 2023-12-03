using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
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
