using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WraithAttackState : WraithGroundState
{
    
    public WraithAttackState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, Wraith_Enemy _wraith) : base(_enemyBase, _stateMachine, _animBollName, _wraith)
    {
    }

    public override void Enter()
    {
        base.Enter();
        wraith.lastTimeAttacked = Time.time;

    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        wraith.SetZeroVelocity();
        if (triggerCalled)
        {
            stateMachine.ChangeState(wraith.battleState);
        }
    }
}
