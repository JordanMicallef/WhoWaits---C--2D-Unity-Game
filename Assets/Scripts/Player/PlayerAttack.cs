using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    private bool attacking = false;
    private float attackTimer = 0;
    private float attackCooldown = 0.3f;

    private Animator anim;

    void Awake()
    {
        //anim = gameObject.GetComponent<Animator>();  
    }

    void Update()
    {
    //    if(Input.GetKeyDown("f") && !attacking)
    //    {
    //        attacking = true;
    //        attackTimer = attackCooldown;

    //        attackTrigger.enabled = true;
    //    }

    //    if(attacking)
    //    {
    //        if(attackTimer > 0)
    //        {
    //            attackTimer -= Time.deltaTime;
    //        }
    //        else
    //        {
    //            attacking = false;
    //            attackTrigger.enabled = false;
    //        }
    //    }

    //    anim.SetBool("Attacking", attacking);
    }
}
