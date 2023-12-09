using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorll : MonoBehaviour
{
    Rigidbody colorballunit;
    Vector3 initPos;
    Quaternion initRot;

    // Start is called before the first frame update
    void Start()
    {
        colorballunit = this.gameObject.GetComponent<Rigidbody>();

        initPos = colorballunit.transform.position;
        initRot = colorballunit.transform.rotation;
    }

    // Update is called once perh frame
    void Update()
    {
        
    }
    
    public void Inclickreset()
    {
        colorballunit.transform.position = initPos;
        colorballunit.transform.rotation = initRot;

        colorballunit.velocity = Vector3.zero;
        colorballunit.angularVelocity = Vector3.zero;

        colorballunit.ResetInertiaTensor();
    }
}
