using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleWitch : Entity
{
    // Start is called before the first frame update
    public float left,
        right;
    public float speed = 1;

    public PurpleWitchStateMachine stateMachine { get; private set; }
    public PurpleWitchMoveState moveState { get; private set; }
    public PurpleWitchIdleState idleState { get; private set; }
    public PurpleWitchAttackState attackState { get; private set; }
    [Header("Move info sw")]
    public float moveSpeed = 5f;
    protected override void Awake()
    {
        base.Awake();
        stateMachine = new PurpleWitchStateMachine();
        moveState = new PurpleWitchMoveState(this, stateMachine, "Move");
        idleState = new PurpleWitchIdleState(this, stateMachine, "Idle");
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
        stateMachine.currentState.Update();
    }
}
