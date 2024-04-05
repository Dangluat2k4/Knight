using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WraithIdleState : EnemyState
{
    private Wraith_Enemy wraith;
    public WraithIdleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, Wraith_Enemy _wraith) : base(_enemyBase, _stateMachine, _animBollName)
    {
        wraith = _wraith;
    }

    public override void Enter()
    {
        base.Enter();
        stateTimer = wraith.idleTime;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (stateTimer < 0)
        {
            stateMachine.ChangeState(wraith.moveState);
        }
    }
}