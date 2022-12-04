using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SoundManager.instance.audioSource.PlayOneShot(SoundManager.instance.coinSound);

            CoinDisplay.instance.UpdateScore(coinValue);
            Destroy(gameObject);
        }
    }
}
