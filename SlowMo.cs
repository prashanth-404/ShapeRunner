using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMo : MonoBehaviour
{
    [Range(0, 5)]
    public float TimeScale = 0.5f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Time.timeScale = TimeScale;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
