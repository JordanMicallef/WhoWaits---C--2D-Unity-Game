using UnityEngine;
using System.Collections;

public abstract class Character : MonoBehaviour
{
    //character variables, serializefield used to edit through unity
    [SerializeField]
    protected float moveSpeed;
    [SerializeField]
    protected float walkTime;
    [SerializeField]
    protected float waitTime;
    [SerializeField]
    public bool isWalking;
    [SerializeField]
    protected int enemycurrentHealth;
    [SerializeField]
    protected int enemymaxHealth;
    [SerializeField]
    protected GameObject itemDrop;


    public Rigidbody2D myRigidBody;
    public PlayerMovement player;

    //sets enemy health
    public virtual void Start()
    {
        //myRigidBody = GetComponent<Rigidbody2D>();
        enemycurrentHealth = enemymaxHealth;  
    }

    // Update is called once per frame
    void Update()
    {
    }

    //damage function from being hit by the player
    public virtual void Damage(int damage)
    {
        enemycurrentHealth -= damage;
        gameObject.GetComponent<Animation>().Play("Red_Flash");
    }

    //death function to be defined
    public abstract void Death();

    public abstract bool IsDead { get; }

    
}
