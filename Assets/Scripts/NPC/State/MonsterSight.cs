using UnityEngine;
using System.Collections;

public class MonsterSight : MonoBehaviour
{
    [SerializeField]
    private Monster monster;

    //public override void Reset()
    //{
    //    target = null;
    //}
    //if a player enters sight, tag is check and target is set to player
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            monster.target = other.gameObject;
            //target = GameObject.Find("Player");
        }
    }

    //if player leaves sight, tag is checked and then target is removed
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            monster.target = null;
        }
    }

    //void Pursuit()
    //{
    //    target = GameObject.Find("Player");

    //    if (target = GameObject.Find("Player"))
    //    {
            
    //    }
    //}
}
