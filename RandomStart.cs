using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStart : MonoBehaviour
{
    private Rigidbody rp;
    // Start is called before the first frame update
    void Start()
    {
        rp = GetComponent<Rigidbody>();
        rp.AddForce(Random.Range(10, 20), Random.Range(10, 20), 0, ForceMode.Impulse);
    }

}
