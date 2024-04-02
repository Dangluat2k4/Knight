using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleWitchGroundState : PurpleWitchState
{
    public PurpleWitchGroundState(PurpleWitch _purpleWitch, PurpleWitchStateMachine _stateMachine, string _animBoolName) : base(_purpleWitch, _stateMachine, _animBoolName)
    {
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
