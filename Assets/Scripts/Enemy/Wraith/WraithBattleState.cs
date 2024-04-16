using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WraithBattleState : EnemyState
{
    // khai bao bien lay vi tri nguoi choi
    private Transform player;
    // khai bao enemy
    private Wraith_Enemy wraith;
    private int moveDir;
  
  
    public WraithBattleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, Wraith_Enemy _wraith) : base(_enemyBase, _stateMachine, _animBollName)
    {
        this.wraith = _wraith;
    }

    public override void Enter()
    {
        base.Enter();
        // tim gameobject co ten la Player trong unity
        player = GameObject.Find("Player").transform;
        Debug.Log("wraith see player");
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (wraith.IsPlayerDetected())
        {
            stateTimer = wraith.BattleTime;

            if (wraith.IsPlayerDetected().distance < wraith.attackDistance)
            {
                if (CanAttack())
                    stateMachine.ChangeState(wraith.attackStateMini);
            }
        }
        else
        {
            if (stateTimer < 0 || Vector2.Distance(player.transform.position, wraith.transform.position) > 7)
                stateMachine.ChangeState(wraith.idleState);
        }

        if (player.position.x > wraith.transform.position.x)
            moveDir = 1;
        else if (player.position.x < wraith.transform.position.x)
            moveDir = -1;

        wraith.SetVelocity(wraith.moveSpeed * moveDir, rb.velocity.y);
    }
    private bool CanAttack()
    {
        if (Time.time >= wraith.lastTimeAttacked + wraith.attackCooldown)
        {
            wraith.lastTimeAttacked = Time.time;
            return true;
        }

        return false;
    }
}
