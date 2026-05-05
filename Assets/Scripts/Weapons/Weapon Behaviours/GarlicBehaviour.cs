using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class GarlicBehaviour : MeleeWeaponBehaviour
{
    List<GameObject> markedEnemies;
    protected override void Start()
    {
        base.Start();
        markedEnemies = new List<GameObject>();
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy") && !markedEnemies.Contains(collision.gameObject))
        {
            EnemyStats enemyStats = collision.GetComponent<EnemyStats>();
            if (enemyStats != null)
            {
                enemyStats.TakeDamage(currentDamage);
                markedEnemies.Add(collision.gameObject);
            }
        }
    }

}
