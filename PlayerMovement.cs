using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float movementspeed = 10f;
    [SerializeField]
    public float forwardSpeed = 10f;
    [SerializeField]
    public float gravitycont = 0.7f;
    public float extra = 3f;
    private Rigidbody rp;

    void Start()
    {
        rp = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad % 20 == 0)
        {
            extra += extra;
        }
        float x = SimpleInput.GetAxis("Horizontal");
        float y = SimpleInput.GetAxis("Vertical");
        rp.AddForce(0, -gravitycont, 0, ForceMode.Force);
        if (rp.useGravity == true)
        {
            transform.Translate(x * movementspeed * Time.deltaTime, 0, forwardSpeed * Time.deltaTime + extra);
        }
        else
        {
            transform.Translate(x * movementspeed * Time.deltaTime, y * movementspeed * Time.deltaTime, forwardSpeed * Time.deltaTime + extra);
        }
    }
}
