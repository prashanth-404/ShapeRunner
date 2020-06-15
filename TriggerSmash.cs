using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSmash : MonoBehaviour
{
    public float raise = 3f;
    private int j = 0;
    Rigidbody rp;
    void Start()
    {
        rp = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (j == 1)
        {
            rp.useGravity = true;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            j = 1;
        }
    }
    void OnTriggerExit(Collider other)
    {
        j = 0;
        transform.Translate(0, raise, 0);
    }

}
