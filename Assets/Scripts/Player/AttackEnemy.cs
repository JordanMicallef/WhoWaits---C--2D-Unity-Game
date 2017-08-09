using UnityEngine;
using System.Collections;

public class AttackEnemy : MonoBehaviour {

    private int dmg = 20;
    public int durabilityLoss;

    //triggered when a object collides with collision box
    void OnTriggerEnter2D(Collider2D other)
    {
        //checks if durability is above 1
        if (DurabilityManage.axeDurability >= 1)
        {
            //checks enemy tag on object
            if (other.gameObject.tag == "Enemy")
            {
                //applies damage output to enemy and durability loss to weapon
                other.SendMessageUpwards("Damage", dmg);
                DurabilityManage.Broken(-durabilityLoss);
            }
        }
    }
    //constant checks for durability
    void Update()
    { 
        //once durability reaches
       if(DurabilityManage.axeDurability <= 0)
        {
            dmg = 0;
        }
    }
}
