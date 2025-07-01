using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour{

    //public Rigidbody myRigibody;

    [SerializeField]
    private Rigidbody myRigibody;
    void Start(){
        //myRigibody = GetComponent<Rigidbody>();
        myRigibody.AddForce(0, 500, 0);
    }
}
