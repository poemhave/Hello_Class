using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{

    public Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.AddForce(500, 500, 0);
    }


}
