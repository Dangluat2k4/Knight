using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleWitchGroundState : EnemyState
{
    protected PurpleWitch purpleWitch;
    public PurpleWitchGroundState(PurpleWitch _purpleWitch, EnemyStateMachine _stateMachine, string _animBoolName, PurpleWitch purpleWitch) : base(_purpleWitch, _stateMachine, _animBoolName)
    {
        this.purpleWitch = purpleWitch;
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
        // tạo trước khi làm dến check người choi
    }
}
