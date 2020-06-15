using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour {
    public float spinSpeed = 180f;

    public float motionMagnitude = 0.1f;

    void Update () {
        gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
        gameObject.transform.Translate (Vector3.up * Mathf.Cos (2 * Time.timeSinceLevelLoad) * motionMagnitude);
    }
}