using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public PC2 PC2;

    public TMP_Text HealthText;



    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //sets the text screen as (Score: ) + total score
        HealthText.text = "Health:" + PC2.health.ToString();

    }
}
