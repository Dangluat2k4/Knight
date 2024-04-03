using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class WraithMini : Enemy
{
    public float left, right;
    public float speed = 1;


    // khai bao 
    public WraithMiniIdleState wraithMiniIdle {  get; private set; }
    public WraithMiniMoveState wraithMiniMove { get; private set; }
    public WraithMiniAttackState wraithMiniAttack { get; private set; }
    protected override void Awake()
    {
        base.Awake();
        wraithMiniIdle = new WraithMiniIdleState(this, stateMachine, "Idle", this);
        wraithMiniMove = new WraithMiniMoveState(this, stateMachine, "Move", this);
        wraithMiniAttack = new WraithMiniAttackState(this, stateMachine, "Attack", this);
    }

    protected override void Start()
    {
        base.Start();
        stateMachine.Initialize(wraithMiniIdle);
    }

    protected override void Update()
    {
        base.Update();
    }
}
