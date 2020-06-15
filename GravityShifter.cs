using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityShifter : MonoBehaviour
{

    public Rigidbody Rigid;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            Rigid.mass = 4; // This can be changed to whatever you want, this is if you want the mass changed;
        Rigid.useGravity = false; // This is if you want to turn the gravity off;
    }

    void OnTriggerExit(Collider other)
    {
        Rigid.mass = 1; // Back to normal here using mass;
        Rigid.useGravity = true; // This is if you want the gravity to be turned back on;
    }

}