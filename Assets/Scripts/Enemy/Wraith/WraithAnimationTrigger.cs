using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WraithAnimationTrigger : MonoBehaviour
{
    private Wraith_Enemy wraith => GetComponentInParent<Wraith_Enemy>();

    private void AnimationTrigger()
    {
        wraith.AnimationFinishTrigger();
    }
    private void CreateFire()
    {
        Instantiate(wraith.bulletMini, wraith.MiniPos.position, transform.rotation);
        wraith.AnimationFinishTrigger();
    }
}
