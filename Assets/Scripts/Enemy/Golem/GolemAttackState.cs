using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemAttackState : GolemGroundState
{
    public GolemAttackState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, Golem _golem) : base(_enemyBase, _stateMachine, _animBollName, _golem)
    {
    }

    public override void Enter()
    {
        base.Enter();
        golem.lastTimeAttacked = Time.time;
    }
    public override void Update()
    {
        base.Update();
        golem.SetZeroVelocity();
        if (triggerCalled)
        {
            stateMachine.ChangeState(golem.battleState);
        }
    }

    public override void Exit()
    {
        base.Exit();
    }


}
