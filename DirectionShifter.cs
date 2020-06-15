using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionShifter : MonoBehaviour
{
    public float jump = 10f;
    public float side = 10f;
    public float forward = 10f;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        Rigidbody rp = player.GetComponent<Rigidbody>();
        rp.AddForce(side, jump, forward, ForceMode.Impulse);
    }
}
