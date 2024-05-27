using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSpeedIncrease : Collectible
{
    public override void Collected(FirstPersonController player)
    {
        player.JumpHeight += 5;
    }
}
