using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skid : MonoBehaviour
{
    public float spsp = 180f;

    public float motion = 0.1f;

    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * spsp * Time.deltaTime);
        gameObject.transform.Translate(Mathf.Cos(Time.timeSinceLevelLoad) * motion, 0, 0);
    }
}
