using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRotate : MonoBehaviour
{
    public float rotatespeed = 3f;
    private int i = 0;

    void Update()
    {
        if (i == 1)
        {
            transform.Rotate(0, rotatespeed * Time.deltaTime, 0);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            i = 1;
        }
    }
    void OnTriggerExit(Collider other)
    {
        i = 0;
    }

}
