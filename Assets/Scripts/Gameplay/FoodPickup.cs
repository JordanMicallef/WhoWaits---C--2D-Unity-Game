using UnityEngine;
using System.Collections;

public class FoodPickup : MonoBehaviour
{
    //public int hungerGain = 10;
    //function begins on collision with circle collider
    void OnTriggerEnter2D(Collider2D other)
    {
        //checks for player tag
        if (other.gameObject.CompareTag("Player"))
        {
            //Uses feed player function and destroys object
            HungerManage.FeedPlayer();
            Destroy(gameObject);
        }
    }
}
