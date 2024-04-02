using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleWitchMoveState : EnemyState
{
    protected PurpleWitch purple;
    // can khoi tao j them lien quan den Move thì ở đây
    public PurpleWitchMoveState(PurpleWitch _purpleWitch, EnemyStateMachine _stateMachine, string _animBoolName, PurpleWitch _purple) : base(_purpleWitch, _stateMachine, _animBoolName)
    {
        this.purple = _purple;
    }

    public override void Enter()
    {
        base.Enter();
        // khi khai báo song phải khởi tạo ở đây
        purple.SetVelocity(purple.moveSpeed * purple.facingDir, rb.velocity.y);
        // rb.velocity = new Vector2(purpleWitch.moveSpeed, 0);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        var purpleWitchPos = purple.transform.position.x;
        if (purpleWitchPos > purple.right)
        {
            Debug.Log("max");
            purple.SetVelocity(-purple.moveSpeed, rb.velocity.y);

        }
        else if (purpleWitchPos < purple.left)
        {

            purple.SetVelocity( purple.moveSpeed, rb.velocity.y);


        }


        // muốn chạy code thì phải update lên 

    }
}
