using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleWitchState 
{
    protected PurpleWitchStateMachine stateMachine;
    // tham chieu den trang thai hien tai cua nhan vat 
    public PurpleWitch purpleWitch;

    protected Rigidbody2D rb;
    protected float xInput;
    protected float yInput;
    private string animBoolName;

    protected float stateTimer;
    protected bool triggerCalled;

    public PurpleWitchState(PurpleWitch _purpleWitch, PurpleWitchStateMachine _stateMachine, string _animBoolName)
    {
        this.purpleWitch = _purpleWitch;
        this.stateMachine = _stateMachine;
        this.animBoolName = _animBoolName;
    }


    public virtual void Enter()
    {
        purpleWitch.anim.SetBool(animBoolName, true);
        rb = purpleWitch.rb;
        // chuyen doi trang thai
        triggerCalled = false;

    }

    public virtual void Update()
    {
        stateTimer -= Time.deltaTime;

        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        // rb = player.rb

    }
    public virtual void Exit()
    {
        purpleWitch.anim.SetBool(animBoolName, false);
    }
    public virtual void AnimationFinishTriger()
    {
        triggerCalled = true;
    }
}

