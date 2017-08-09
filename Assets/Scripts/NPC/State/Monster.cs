using UnityEngine;
using System.Collections;

public class Monster : Character
{
    public GameObject target { get; set; }
    private InterfaceState currentState;
    public Collider2D walkZone;
    private Rigidbody2D monsterRigidBody;
    [SerializeField]
    private float distRange;
    private int walkDirection;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;
    private bool hasWalkZone;
    
    private float walkCount;
    private float waitCount;

    private Vector3 playerTrack;
    private Vector2 playerDirection;
    private float xDif;
    private float yDif;
    private float speed;
    // Use this for initialization

    public override void Start ()
    {
        //set the values from character in here that are needed for the monster
        base.Start();
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        monsterRigidBody = GetComponent<Rigidbody2D>();
        ChangeState(new IdleState());
    }

    // Update is called once per frame
    void Update()
    {
        //if (!IsDead) //If the enemy i alive
        //{
        //    if (!TakingDamage) //if we aren't taking damage
        //    {
        //        //Execute the current state, this can make the enemy move or attack etc.
        //        currentState.Execute();
        //    }
        //}  
        Death();
        currentState.Execute();
    }

    //changes the monsters state depending on presdefined rules in the classes
    public void ChangeState(InterfaceState newState)
    {
        if (currentState != null)
        {
            currentState.Exit();
        }

        currentState = newState;

        currentState.MonsterE(this);
    }

    //tracks the player object once it is a target
    public void Track()
    {
        speed = 3.7f;
        playerTrack = GameObject.Find("Player").transform.position;
        xDif = playerTrack.x - transform.position.x;
        yDif = playerTrack.y - transform.position.y;
        playerDirection = new Vector2(xDif, yDif);
        GetComponent<Rigidbody2D>().AddForce(playerDirection * speed);
        Debug.Log(playerDirection);
    }

    //public bool InThrowRange
    //{
    //    get
    //    {
    //        if (target != null)
    //        {
    //            return Vector2.Distance(transform.position, target.transform.position) <= distRange;

    //        }

    //        return false;
    //    }
    //}

    public override bool IsDead
    {
        get
        {
            return enemycurrentHealth <= 0;
        }
    }
    //controls when the enemy dies and destroying the object
    public override void Death()
    {
        if (enemycurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void RemoveTarget()
    {
        //Removes the target
        target = null;
    }
    //Checks for a box collider boundary to then allow movement within it
    public void WalkZoneCheck()
    {
        if (walkZone != null)
        {
            minWalkPoint = walkZone.bounds.min;
            maxWalkPoint = walkZone.bounds.max;
            hasWalkZone = true;
        }
    }

    public void Walking()
    {
        if (isWalking == true)
        {
            walkCount -= Time.deltaTime;

            switch (walkDirection)
            {
                case 0:
                    monsterRigidBody.velocity = new Vector2(0, moveSpeed);
                    if (hasWalkZone && transform.position.y > maxWalkPoint.y)
                    {
                        isWalking = false;
                        waitCount = waitTime;
                    }
                    break;

                case 1:
                    monsterRigidBody.velocity = new Vector2(moveSpeed, 0);
                    if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                    {
                        isWalking = false;
                        waitCount = waitTime;
                    }
                    break;

                case 2:
                    monsterRigidBody.velocity = new Vector2(0, -moveSpeed);
                    if (hasWalkZone && transform.position.y < minWalkPoint.y)
                    {
                        isWalking = false;
                        waitCount = waitTime;
                    }
                    break;

                case 3:
                    monsterRigidBody.velocity = new Vector2(-moveSpeed, 0);
                    if (hasWalkZone && transform.position.x < minWalkPoint.x)
                    {
                        isWalking = false;
                        waitCount = waitTime;
                    }
                    break;
            }

            if (walkCount < 0)
            {
                isWalking = false;
                waitCount = waitTime;
            }
        }
        else
        {
            waitCount -= Time.deltaTime;
            monsterRigidBody.velocity = Vector2.zero;

            if (waitCount < 0)
            {
                ChooseDirection();
            }
        }
    }
  
    public void ChooseDirection()
    {
        walkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCount = walkTime;
    }

}
