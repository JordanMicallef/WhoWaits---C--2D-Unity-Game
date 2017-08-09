using UnityEngine;
using System.Collections;

//handles execution of different states as well as common functionality across all state classes
public interface InterfaceState
{
    void MonsterE(Monster monster);
    void Execute();
    void Exit();
    void OnTriggerEnter(Collider2D other);
}
