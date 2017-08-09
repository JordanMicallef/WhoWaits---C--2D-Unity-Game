﻿using UnityEngine;
using System.Collections;

public class Jack : Character
{
    private int walkDirection;
    private Vector2 minWalkPoint;
    private Vector2 maxWalkPoint;
    private bool hasWalkZone;
    private float walkCount;
    private float waitCount;
    public Collider2D walkZone;
    private Rigidbody2D jackRigidBody;

    
    // Use this for initialization
    public override void Start()
    {
        base.Start();
        ChooseDirection();
        WalkZoneCheck();
        jackRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Walking();
    }

    //Change the direction of npc
    public void ChooseDirection()
    {
        walkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCount = walkTime;
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
                    jackRigidBody.velocity = new Vector2(0, moveSpeed);
                    if (hasWalkZone && transform.position.y > maxWalkPoint.y)
                    {
                        isWalking = false;
                        waitCount = waitTime;
                    }
                    break;

                case 1:
                    jackRigidBody.velocity = new Vector2(moveSpeed, 0);
                    if (hasWalkZone && transform.position.x > maxWalkPoint.x)
                    {
                        isWalking = false;
                        waitCount = waitTime;
                    }
                    break;

                case 2:
                    jackRigidBody.velocity = new Vector2(0, -moveSpeed);
                    if (hasWalkZone && transform.position.y < minWalkPoint.y)
                    {
                        isWalking = false;
                        waitCount = waitTime;
                    }
                    break;

                case 3:
                    jackRigidBody.velocity = new Vector2(-moveSpeed, 0);
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
            jackRigidBody.velocity = Vector2.zero;

            if (waitCount < 0)
            {
                ChooseDirection();
            }
        }
    }

    public override void Death()
    {
    }

    public override bool IsDead
    {
        get
        {
            return false;
        }
    }
}