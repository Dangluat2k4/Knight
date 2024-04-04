using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemAttackState : GolemGroundState
{
    protected Golem golem;

    public GolemAttackState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, Golem _golem) : base(_enemyBase, _stateMachine, _animBollName, _golem)
    {
        golem = _golem;
    }
}
