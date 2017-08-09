using UnityEngine;
using System.Collections;

public class BadPickup : MonoBehaviour
{
   // public int hungerGain = 20;
   //used by bad pickup drop, to hurt the player
    void OnTriggerEnter2D(Collider2D other)
    {
        //checks for player tag
        if (other.gameObject.CompareTag("Player"))
        {
            HungerManage.HurtPlayer();
            ThirstManage.HurtPlayer();
            Destroy(gameObject);
        }
    }
}
