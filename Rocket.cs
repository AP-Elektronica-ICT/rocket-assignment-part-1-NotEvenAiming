using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float rotationSpeed = 0;
    private bool Thrust = false;

   
    void Start()
    {
        
    }

    void CheckThrustKeyPress()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Thrust = true;
        }else
        {
            Thrust = false;
        }
    }

    void CheckRotationKeyPress()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rotationSpeed);
        }
    }

    void ApplyRocketThrust()
    {
        if (Thrust)
        {
            Vector3 force = transform.up * 4;

            GetComponent<Rigidbody>().AddForce(force);
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckThrustKeyPress();
        CheckRotationKeyPress();
        ApplyRocketThrust();
    }
}
