using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SoundManager.instance.audioSource.PlayOneShot(SoundManager.instance.fuelSound);

            FuelDisplay.instance.AddFuel();
            Destroy(gameObject);
        }
    }
}
