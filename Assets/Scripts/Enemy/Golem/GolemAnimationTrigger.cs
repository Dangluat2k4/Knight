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
}
