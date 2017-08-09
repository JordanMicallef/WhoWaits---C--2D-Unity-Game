using UnityEngine;
using System.Collections;
using System;

public class MovingState : InterfaceState
{
    private Monster monster;
    private float patrolTimer;
    private float patrolCount;

    public void Execute()
    {
        //sets the monster to patrol and move
        Debug.Log("PATROLLING!");
        Patrol();
        monster.Walking();
        //if a target is set then the monster changes to attack state
        if (monster.target != null)
        {
            monster.ChangeState(new AttackState());
        }
    }

    public void Exit()
    {
        
    }

    public void MonsterE(Monster monster)
    {
        this.monster = monster;
    }

    public void OnTriggerEnter(Collider2D other)
    {
        
    }

    public void Patrol()
    {
        //monster.isWalking = true;
        //patrolTimer += Time.deltaTime;

        //if (patrolTimer >= patrolCount)
        //{
        //    monster.ChangeState(new IdleState());
        //}
    }
}
