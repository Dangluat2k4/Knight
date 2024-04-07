using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleWitch : Enemy
{
    // Start is called before the first frame update
    public float left, right;
    public float speed = 1;

    // Remove the redeclaration of stateMachine here

    public PurpleWitchMoveState moveState { get; private set; }
    public PurpleWitchIdleState idleState { get; private set; }
    public PurpleWitchAttackState attackState { get; private set; }

    protected override void Awake()
    {
        base.Awake();
        moveState = new PurpleWitchMoveState(this, stateMachine, "Move", this);
        idleState = new PurpleWitchIdleState(this, stateMachine, "Idle", this);
        attackState = new PurpleWitchAttackState(this, stateMachine, "Attack");
    }

    protected override void Start()
    {
        base.Start();
        stateMachine.Initialize(moveState);
    }

    protected override void Update()
    {
        base.Update();
    }
}
