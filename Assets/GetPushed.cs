using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPushed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        this.GetComponent<Rigidbody>().AddForce(0, 0, 0.1f);
    }
}
