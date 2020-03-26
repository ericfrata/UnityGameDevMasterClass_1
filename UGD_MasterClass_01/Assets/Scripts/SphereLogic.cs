using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLogic : MonoBehaviour
{
       Rigidbody m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        //This locks the RigidBody so that it does not move or rotate in the Z axis.
        // m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
    }
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(new Vector3(0, 500, 0));

        }
    }
}
