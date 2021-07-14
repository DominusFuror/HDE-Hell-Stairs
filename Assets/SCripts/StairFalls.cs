using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairFalls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       
        
    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        Invoke("StairsFall", 3f);
    }
    void Update()
    {
        
    }

    public void StairsFall()
    {
        gameObject.AddComponent<Rigidbody>();
        Invoke("Destroy", 2f);


    }
    public void Destroy()
    {
        Destroy(this.transform.parent.gameObject);
    }


}
