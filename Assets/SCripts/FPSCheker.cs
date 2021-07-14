using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCheker : MonoBehaviour
{
    float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0.2f)
        {

            this.GetComponent<Text>().text = 1f / Time.deltaTime + "";
            timer = 0;
        
        }
        timer += Time.deltaTime;
    }
}
