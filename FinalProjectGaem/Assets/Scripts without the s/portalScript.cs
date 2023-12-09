using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalScript : MonoBehaviour
{
    public GameObject teleportPoint;

    public bool PortalClosed = true;


    // Update is called once per frame
    void Update()
    {
        if (PortalClosed == true)
        {
            gameObject.GetComponent<Collider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            //gameObject.SetActive(false);
        }
        if (PortalClosed == false)
        {
            gameObject.GetComponent<Collider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            //gameObject.SetActive(true);
        }
    }
}
