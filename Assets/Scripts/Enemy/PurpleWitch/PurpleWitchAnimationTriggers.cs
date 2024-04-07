using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleWitchAnimationTriggers : MonoBehaviour
{
    private Golem  golem => GetComponentInParent<Golem>();

    private void AnimationTrigger()
    {
        golem.AnimationFinishTrigger();
    }
}
 