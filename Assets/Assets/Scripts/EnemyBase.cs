using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    protected virtual void AttackPlayer(GameObject gameObject)
    {
        Debug.Log("[" + this.gameObject.name + "] Enemy is attacking " + gameObject);
    }
}
