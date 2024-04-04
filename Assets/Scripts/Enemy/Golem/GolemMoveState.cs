using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemMoveState : GolemGroundState
{
    protected Golem golem;
    public GolemMoveState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, Golem _golem) : base(_enemyBase, _stateMachine, _animBollName, _golem)
    {
        this.golem = _golem;
    }

    public override void Enter()
    {
        base.Enter();
        
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        var golemPos = golem.transform.position.x;
        golem.SetVelocity(golem.moveSpeed * golem.facingDir, rb.velocity.y);

        if (golemPos > golem.right)
        {
            Debug.Log("golemmax");
            golem.SetVelocity(-golem.moveSpeed, rb.velocity.y);

        }
        else if (golemPos < golem.left)
        {
            golem.SetVelocity(golem.moveSpeed, rb.velocity.y);


        }
    }
}
