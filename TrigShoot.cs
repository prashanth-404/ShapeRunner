using System.Collections;
using UnityEngine;

public class TrigShoot : MonoBehaviour
{

    // Reference to projectile prefab to shoot
    public GameObject projectile;
    public float power = 200.0f;

    // Reference to AudioClip to play
    public AudioClip shootSFX;
    private int i = 0;

    // Update is called once per frame
    void Update()
    {
        // Detect if fire button is pressed
        if (i == 1)
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
                    { // the projectile has an AudioSource component
                        // play the sound clip through the AudioSource component on the gameobject.
                        // note: The audio will travel with the gameobject.
                        newProjectile.GetComponent<AudioSource>().PlayOneShot(shootSFX);
                    }
                    else
                    {
                        // dynamically create a new gameObject with an AudioSource
                        // this automatically destroys itself once the audio is done
                        AudioSource.PlayClipAtPoint(shootSFX, newProjectile.transform.position);
                    }
                }
            }
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
