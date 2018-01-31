using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    public EnemyPlayers enemyPlayer;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemys")
        {
            Destroy(bullet);
            enemyPlayer.health =- 50;
        }
    }
}