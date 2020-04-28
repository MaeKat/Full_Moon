﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : Enemy
{
    private Rigidbody2D myRigidbody;
    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform homePosition;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemyState.idle;
        myRigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckDistance();
    }

    void CheckDistance()
	{
        if(Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
		{
            if(currentState == EnemyState.idle || currentState == EnemyState.walk && currentState != EnemyState.stagger)
			{
                Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                ChangeAnim(temp - transform.position);
                myRigidbody.MovePosition(temp);
                ChangeState(EnemyState.walk);
                anim.SetBool("wakeUp", true);
            }
			else
			{
                anim.SetBool("wakeUp", false);
			}
		}
	}

    private void ChangeAnim(Vector2 direction)
	{
        direction = direction.normalized;
        anim.SetFloat("moveX", direction.x);
        anim.SetFloat("moveY", direction.y);
    }

    private void ChangeState(EnemyState newState)
	{
        if(currentState != newState)
		{
            currentState = newState;
		}
	}
}