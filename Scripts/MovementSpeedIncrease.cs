using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSpeedIncrease : Collectible
{
    public override void Collected(FirstPersonController player)
    {
        player.MoveSpeed += 5;
    }
}
