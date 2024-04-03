using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnivorousFlowerIdleState : EnemyState
{
    protected CarnivorousFlower carnivorous;
    public CarnivorousFlowerIdleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, CarnivorousFlower _carnivorous) : base(_enemyBase, _stateMachine, _animBollName)
    {
        this.carnivorous = _carnivorous;
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
