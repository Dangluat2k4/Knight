using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnivorousFlowerIdleState : EnemyState
{
    protected CarnivorousFlower carnivorous;

    public CarnivorousFlowerIdleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, CarnivorousFlower carnivorous) : base(_enemyBase, _stateMachine, _animBollName)
    {
        this.carnivorous = carnivorous;
    }

    public override void Enter()
    {
        base.Enter();
        stateTimer = carnivorous.idleTime;

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
