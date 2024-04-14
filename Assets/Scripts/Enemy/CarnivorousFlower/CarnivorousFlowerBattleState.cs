using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnivorousFlowerBattleState : EnemyState
{
    private Transform player;
    private CarnivorousFlower flower;
    private CarnivorousFlower carnivorous;
    public CarnivorousFlowerBattleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, CarnivorousFlower _flower) : base(_enemyBase, _stateMachine, _animBollName)
    {
        this.flower = _flower;
    }

    public override void Enter()
    {
        base.Enter();
        player = GameObject.Find("Player").transform;
        Debug.Log("Im in battle state");
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
