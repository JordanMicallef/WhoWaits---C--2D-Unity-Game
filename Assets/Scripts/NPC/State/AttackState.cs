using UnityEngine;
using System.Collections;

//attack state class used by the monster class
public class AttackState : InterfaceState
{
    private Monster monster; 

    //Execute function for attack state
    public void Execute()
    {
        Debug.Log("I'm attacking");
        if (monster.target != null)
        {
            //monster follows player if target is true
            monster.Track();
        }
        else
        {
            //changes monster back to moving state
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
}
