using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnivorousFlowerAnimationTiggers : MonoBehaviour
{
    private CarnivorousFlower carnivorous => GetComponentInParent<CarnivorousFlower>();

    private void AnimationTrigger()
    {
        carnivorous.AnimationFinishTrigger();
    }
}
