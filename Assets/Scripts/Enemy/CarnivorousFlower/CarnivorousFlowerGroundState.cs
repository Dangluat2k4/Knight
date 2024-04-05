using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnivorousFlowerGroundState : EnemyState
{
    protected CarnivorousFlower CarnivorousFlower;
    public CarnivorousFlowerGroundState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, CarnivorousFlower carnivorousFlower) : base(_enemyBase, _stateMachine, _animBollName)
    {
        this.CarnivorousFlower = carnivorousFlower;
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
