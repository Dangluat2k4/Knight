using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleWitchMoveState : PurpleWitchState
{
    // can khoi tao j them lien quan den Move thì ở đây
    public PurpleWitchMoveState(PurpleWitch _purpleWitch, PurpleWitchStateMachine _stateMachine, string _animBoolName) : base(_purpleWitch, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        // khi khai báo song phải khởi tạo ở đây
        rb.velocity = new Vector2(purpleWitch.moveSpeed, 0);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        var purpleWitchPos = purpleWitch.transform.position.x;
        if (purpleWitchPos > purpleWitch.right)
        {
            Debug.Log("max");
            purpleWitch.SetVelocity(-purpleWitch.moveSpeed, rb.velocity.y);

        }
        else if (purpleWitchPos < purpleWitch.left)
        {

            purpleWitch.SetVelocity(purpleWitch.moveSpeed, rb.velocity.y);
            Debug.Log(purpleWitch.transform.position.x);

        }


        // muốn chạy code thì phải update lên 

    }
}
