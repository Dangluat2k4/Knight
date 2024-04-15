using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WraithMiniBattleState : EnemyState
{
    private Transform player;
    private WraithMini wraithMini;
    private int moveDir;
    public WraithMiniBattleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, WraithMini _wraithMini) : base(_enemyBase, _stateMachine, _animBollName)
    {
        this.wraithMini = _wraithMini;
    }

    public override void Enter()
    {
        base.Enter();
        player = GameObject.Find("Player").transform;
        Debug.Log("Im in battle state");
    }


    public override void Update()
    {
        base.Update();

        // Tính toán hướng đi hướng về người chơi
        Vector2 direction = (player.position - wraithMini.transform.position).normalized;

        if (wraithMini.IsPlayerDetected())
        {
            stateTimer = wraithMini.BattleTime;

            if (wraithMini.IsPlayerDetected().distance < wraithMini.attackDistance)
            {
                if (CanAttack())
                    stateMachine.ChangeState(wraithMini.wraithMiniAttack);
            }
        }   
        else
        {
            if (stateTimer < 0 || Vector2.Distance(player.transform.position, wraithMini.transform.position) > 7)
                stateMachine.ChangeState(wraithMini.wraithMiniIdle);
        }


        if (direction.x > 0)
            moveDir = 1;
        else if (direction.x < 0)
            moveDir = -1;

        wraithMini.SetVelocity(wraithMini.moveSpeed * direction.x, wraithMini.moveSpeed * direction.y);
    }
    public override void Exit()
    {
        base.Exit();
    }
    private bool CanAttack()
    {
        if (Time.time >=wraithMini.lastTimeAttacked + wraithMini.attackCooldown)
        {
            wraithMini.lastTimeAttacked = Time.time;
            return true;
        }

        return false;
    }
}
