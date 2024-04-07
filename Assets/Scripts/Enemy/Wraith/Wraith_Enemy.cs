using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wraith_Enemy : Enemy
{
    public float left, right;
    public float speed = 1;

    #region State
    public WraithIdleState idleState { get; private set; }
    public WraithMoveState moveState { get; private set; }
    #endregion
    protected override void Awake()
    {
        base.Awake();


        idleState = new WraithIdleState(this, stateMachine, "Idle", this);
        moveState = new WraithMoveState(this, stateMachine, "Move", this);
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
