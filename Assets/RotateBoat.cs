using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoat : MonoBehaviour
{
    public float rotationSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Transform>().Rotate(0, 0, rotationSpeed);
            this.GetComponent<Rigidbody>().AddForce(0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Transform>().Rotate(0, 0, -rotationSpeed);
            this.GetComponent<Rigidbody>().AddForce(-0.1f, 0, 0);
        }

    }

}
