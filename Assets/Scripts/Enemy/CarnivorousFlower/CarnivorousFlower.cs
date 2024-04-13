using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarnivorousFlower : Enemy
{

    public CarnivorousFlowerIdleState idleState { get; private set; }
    public CarnivorousFlowerAttackState attackState { get; private set; }
    public CarnivorousFlowerBattleState battleState { get; private set; }

    protected override void Awake()
    {
        base.Awake();

        idleState = new CarnivorousFlowerIdleState(this, stateMachine, "Idle", this);
        attackState = new CarnivorousFlowerAttackState(this, stateMachine, "Attack");
        battleState = new CarnivorousFlowerBattleState(this, stateMachine, "Move", this);

    }

    protected override void Start()
    {
        base.Start();
        stateMachine.Initialize(idleState);

    }

    protected override void Update()
    {
        base.Update();
    }
}
