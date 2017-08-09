using UnityEngine;
using System.Collections;

public abstract class ActionManage : MonoBehaviour
{
    public GameObject target;
    private bool inRange = false;
    public bool isWalking;
    public abstract void Reset();
}
