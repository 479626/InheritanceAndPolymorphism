using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardScript : EnemyBase
{
    void Start()
    {
        AttackPlayer(GameObject.FindGameObjectWithTag("Player"));
    }
}
