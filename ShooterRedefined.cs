using UnityEngine;
using System.Collections;

public class ShooterRedefined : MonoBehaviour
{

    // Reference to projectile prefab to shoot
    public GameObject projectile;
    public float power = 10.0f;

    // Reference to AudioClip to play
    public AudioClip shootSFX;
    private int gal = 0;

    // Update is called once per frame
    void Update()
    {
        // Detect if fire button is pressed
        if (gal == 1 && Time.timeSinceLevelLoad % 0.5 <= 0.1)
        {
            // if projectile is specified
            if (projectile)
            {
                // Instantiante projectile at the camera + 1 meter forward with camera rotation
                GameObject newProjectile = Instantiate(projectile, transform.position + transform.forward, transform.rotation) as GameObject;

                // if the projectile does not have a rigidbody component, add one
                if (!newProjectile.GetComponent<Rigidbody>())
                {
                    newProjectile.AddComponent<Rigidbody>();
                }
                // Apply force to the newProjectile's Rigidbody component if it has one
                newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.VelocityChange);

                // play sound effect if set
                if (shootSFX)
                {
                    if (newProjectile.GetComponent<AudioSource>())
                    {
                        newProjectile.GetComponent<AudioSource>().PlayOneShot(shootSFX);
                    }
                    else
                    {
                        AudioSource.PlayClipAtPoint(shootSFX, newProjectile.transform.position);
                    }
                }
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        gal = 1;
    }
    void OnTriggerExit(Collider other)
    {
        gal = 0;
    }

}

