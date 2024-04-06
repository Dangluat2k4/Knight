using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WraithMiniAttackState : EnemyState
{
    protected WraithMini wraithMini;
    public WraithMiniAttackState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, WraithMini _wraithMini) : base(_enemyBase, _stateMachine, _animBollName)
    {
        this.wraithMini = _wraithMini;
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
    }
}
