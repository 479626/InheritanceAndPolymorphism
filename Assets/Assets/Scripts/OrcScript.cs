using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcScript : EnemyBase
{
    void Start()
    {
        AttackPlayer(GameObject.FindGameObjectWithTag("Player"));
    }
}
