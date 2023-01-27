using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip CoinPickupSFX;
    [SerializeField] int valueOfCoin = 100;

    bool isWasCollected = false; 

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player" && !isWasCollected)
        {
            isWasCollected=true;
            AudioSource.PlayClipAtPoint(CoinPickupSFX, Camera.main.transform.position);
            FindObjectOfType<GameSession>().UpdateScoreText(valueOfCoin);
            Destroy(gameObject);
        }
    }
}
