using UnityEngine;
using System.Collections;

public class IdleState : InterfaceState
{
    private Monster monster;
    private float idletimer;
    private float idlecount = 5f;

    public void Execute()
    {
        Debug.Log("I'm idle");
        Idle();
        //sets the monster into a moving state from idle if a target is set
        if (monster.target != null)
        {
            monster.ChangeState(new MovingState());
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

    //Sets the monster to be idea for a timer set upon game start
    public void Idle()
    {
        monster.isWalking = false;
        idletimer += Time.deltaTime;
        if (idletimer >= idlecount)
        {
            //once timer finishes the monster changes state to moving
            monster.ChangeState(new MovingState());
        }
    }
}
