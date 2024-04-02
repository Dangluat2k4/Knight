using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleWitchIdleState : EnemyState
{
    protected PurpleWitch purple;
    public PurpleWitchIdleState(PurpleWitch _purpleWitch, EnemyStateMachine _stateMachine, string _animBoolName, PurpleWitch _purple) : base(_purpleWitch, _stateMachine, _animBoolName)
    {
        this.purple = _purple;
    }

    public override void Enter()
    {
        base.Enter();
        stateTimer = purple.idleTime;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (stateTimer < 0)
        {
            stateMachine.ChangeState(purple.moveState);
        }
    }
}

