using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smasher : MonoBehaviour
{
    public float smashspeed = 5f;
    private float var = 0f;
    void OnTriggerEnter(Collider other)
    {
        var = 1f;
    }

    void Update()
    {
        if (var == 1f)
        {
            if (transform.position.x < 0)
            {
                transform.Translate(smashspeed, 0, 0);
            }
            else
            {
                transform.Translate(smashspeed, 0, 0);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        var = 0f;
        if (transform.position.x < 0)
        {
            transform.Translate(smashspeed * 10, 0, 0);
        }
        else
        {
            transform.Translate(smashspeed * 10, 0, 0);
        }
    }

}
