using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleWitchAnimationTriggers : MonoBehaviour
{
    private PurpleWitch  purpleWitch => GetComponentInParent<PurpleWitch>();

    private void AnimationTrigger()
    {
        purpleWitch.AnimationFinishTrigger();
    }
}
 