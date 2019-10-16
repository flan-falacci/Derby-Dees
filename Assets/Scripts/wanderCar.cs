using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wanderCar : MonoBehaviour
{

    Vector3 direction; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion newRotation = transform.localRotation;
        transform.localRotation = Quaternion.Euler(0, newRotation.eulerAngles.y, newRotation.eulerAngles.z);
    }
}
