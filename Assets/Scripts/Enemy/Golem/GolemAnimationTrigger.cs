using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemAnimationTrigger : MonoBehaviour
{
    private Golem golem => GetComponentInParent<Golem>();

    private void AnimationTrigger()
    {
        golem.AnimationFinishTrigger();
    }
    private void AttackTrigger()
    {
        Collider2D[] collider2s = Physics2D.OverlapCircleAll(golem.attackCkeck.position, golem.attackCkeckRadius);
        foreach(var hit in collider2s)
        {
            if (hit.GetComponent<Player>() != null)
            {
                hit.GetComponent<Player>().Damage();
                hit.GetComponent<CharacterStats>().TakeDamage(golem.stats.damage);
            }
        }
    }
}
