using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerevent : MonoBehaviour
{
    public float levelup = 3f;

    void OnTriggerEnter(Collider other)
    {
        transform.Translate(0, levelup, 0);
    }
    void OnTriggerExit(Collider other)
    {
        transform.Translate(0, -levelup, 0);
    }

}
