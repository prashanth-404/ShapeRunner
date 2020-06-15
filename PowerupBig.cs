using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupBig : MonoBehaviour
{
    public float mult = 1.4f;

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
        player.transform.localScale *= mult;
    }
}
