using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnivorousFlower : Enemy
{
    public CarnivorousFlowerIdleState idleState { get; private set; }
    public CarnivorousFlowerAttackState attackState { get; private set; }

    protected override void Awake()
    {
        base.Awake();
        idleState = new CarnivorousFlowerIdleState(this, stateMachine, "Idle", this);
        attackState = new CarnivorousFlowerAttackState(this, stateMachine, "Attack");
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
