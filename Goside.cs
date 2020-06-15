using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goside : MonoBehaviour
{
    [SerializeField]
    private float frc = 5f;
    private Rigidbody rp;
    // Start is called before the first frame update
    void Start()
    {
        rp = GetComponent<Rigidbody>();
        rp.AddForce(frc, 0, 0, ForceMode.Impulse);
    }

}
