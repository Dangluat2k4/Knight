using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnivorousFlowerBattleState : EnemyState
{

    // khai bao bien lay vi tri nguoi choi
    private Transform player;
    // khai bao enemy
    private CarnivorousFlower carnivorousFlower;
    private int moveDir;
    public CarnivorousFlowerBattleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName, CarnivorousFlower _carnivorousFlower) : base(_enemyBase, _stateMachine, _animBollName)
    {
        this.carnivorousFlower = _carnivorousFlower;
    }

    public override void Enter()
    {
        base.Enter();

        // tim gameobject co ten la Player trong unity
        player = GameObject.Find("Player").transform;
        Debug.Log("Im in battle state");
    }

    public override void Exit()
    {
        base.Exit();

        if (carnivorousFlower.IsPlayerDetected())
        {
            stateTimer = carnivorousFlower.BattleTime;

            if (carnivorousFlower.IsPlayerDetected().distance < carnivorousFlower.attackDistance)
            {
                if (CanAttack())
                    stateMachine.ChangeState(carnivorousFlower.attackState);
            }
        }
        else
        {
            if (stateTimer < 0 || Vector2.Distance(player.transform.position, carnivorousFlower.transform.position) > 7)
                stateMachine.ChangeState(carnivorousFlower.idleState);
        }


    }

    public override void Update()
    {
        base.Update();
    }

    private bool CanAttack()
    {
        if (Time.time >= carnivorousFlower.lastTimeAttacked + carnivorousFlower.attackCooldown)
        {
            carnivorousFlower.lastTimeAttacked = Time.time;
            return true;
        }

        return false;
    }
}
