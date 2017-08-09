using UnityEngine;
using System.Collections;

public class WaterPickup : MonoBehaviour
{
    //public int thirstGain;
    //function begins on collision with circle collider
    void OnTriggerEnter2D (Collider2D other)
    {
        //checks for player tag
        if (other.gameObject.CompareTag("Player"))
        {
            //Uses drink player function and destroys object
            ThirstManage.DrinkPlayer();
            Destroy(gameObject);
        }
    }
}
