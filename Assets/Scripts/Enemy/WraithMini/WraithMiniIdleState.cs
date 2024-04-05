using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WraithMiniIdleState : EnemyState
{
    protected WraithMini wraithMini;
    public WraithMiniIdleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, WraithMini _wraithMini) : base(_enemyBase, _stateMachine, _animBollName)
    {
        this.wraithMini = _wraithMini;
    }

    public override void Enter()
    {
        base.Enter();
        stateTimer = wraithMini.idleTime;
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
            stateMachine.ChangeState(wraithMini.wraithMiniMove);
        }
    }
}
