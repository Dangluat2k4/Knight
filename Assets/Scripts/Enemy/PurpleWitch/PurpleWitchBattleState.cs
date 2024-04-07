using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleWitchBattleState : EnemyState
{
    private PurpleWitch purpleWitch;
    private Transform player;
    private int moveDir;
    public PurpleWitchBattleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, PurpleWitch _purpleWitch) : base(_enemyBase, _stateMachine, _animBollName)
    {
        this.purpleWitch = _purpleWitch;
    }

    public override void Enter()
    {
        base.Enter();
        player = GameObject.Find("Player").transform;
        Debug.Log("Im in battle state");
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (purpleWitch.IsPlayerDetected())
        {
            stateTimer = purpleWitch.BattleTime;

            if (purpleWitch.IsPlayerDetected().distance < purpleWitch.attackDistance)
            {
                if (CanAttack())
                    stateMachine.ChangeState(purpleWitch.attackState);
            }
        }
        else
        {
            if (stateTimer < 0 || Vector2.Distance(player.transform.position, purpleWitch.transform.position) > 7)
                stateMachine.ChangeState(purpleWitch.idleState);
        }

        if (player.position.x > purpleWitch.transform.position.x)
            moveDir = 1;
        else if (player.position.x < purpleWitch.transform.position.x)
            moveDir = -1;

        purpleWitch.SetVelocity(purpleWitch.moveSpeed * moveDir, rb.velocity.y);
    }

    private bool CanAttack()
    {
        if (Time.time >= purpleWitch.lastTimeAttacked + purpleWitch.attackCooldown)
        {
            purpleWitch.lastTimeAttacked = Time.time;
            return true;
        }

        return false;
    }
}
