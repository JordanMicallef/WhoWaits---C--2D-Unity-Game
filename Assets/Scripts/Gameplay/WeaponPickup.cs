using UnityEngine;
using System.Collections;

public class WeaponPickup : MonoBehaviour
{
    public int durabilityGain;
    //function begins on collision with circle collider
    void OnTriggerEnter2D(Collider2D other)
    {
        //checks for player tag
        if (other.gameObject.CompareTag("Player"))
        {
            //Uses fix function with a set variable and destroys object
            DurabilityManage.FixAxe(+durabilityGain);
            Destroy(gameObject);
        }
    }
}


