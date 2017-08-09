using UnityEngine;
using System.Collections;

public class MonsterAttack : MonoBehaviour
{
    //triggers damage output once enemy is within players box collider
    void OnTriggerEnter2D(Collider2D other)
    {
        //checks for player as a tag on the object
        if (other.gameObject.tag == "Player")
        {
            //other.SendMessageUpwards("Damage", dmg);
            HungerManage.HurtPlayer();
            other.gameObject.GetComponent<Animation>().Play("Red_Flash");
        }
    }
}