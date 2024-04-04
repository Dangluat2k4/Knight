using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemIdleState : GolemGroundState
{
    protected Golem golem;
    public GolemIdleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, Golem _golem) : base(_enemyBase, _stateMachine, _animBollName, _golem)
    {
        this.golem = _golem;
    }

    public override void Enter()
    {
        base.Enter();
        stateTimer = 1f;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (stateTimer < 0f)
        {
            stateMachine.ChangeState(golem.moveState);
        }
    }
}
