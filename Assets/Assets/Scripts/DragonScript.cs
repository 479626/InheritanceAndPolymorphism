using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScript : EnemyBase
{
    void Start()
    {
        AttackPlayer(GameObject.FindGameObjectWithTag("Player"));
    }
}
