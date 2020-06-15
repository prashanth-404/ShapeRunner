using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxShifter : MonoBehaviour
{
    public float shift = 240f;

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.Translate(0, 0, shift);
        }

    }

}