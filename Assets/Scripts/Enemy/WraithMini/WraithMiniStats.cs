using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WraithMiniStats : CharacterStats
{
    private WraithMini wraithMini;
    public override void Die()
    {
        base.Die();
        wraithMini = GetComponent<WraithMini>();
    }

    public override void TakeDamage(int _damage)
    {
        base.TakeDamage(_damage);
        wraithMini.Damage();
    }

    protected override void Start()
    {
        base.Start();
    }
}
