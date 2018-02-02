using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    public EnemyPlayers enemyPlayer;
    public EnemyPlayers enemyPlayer2;
    public EnemyPlayers enemyPlayer3;
    public GameObject[] enemys;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy1")
        {
            Destroy(bullet);
            enemyPlayer.health -= 50;
        }
        else if (collision.gameObject.tag == "Enemy2")
        {
            Destroy(bullet);
            enemyPlayer2.health -= 50;
        }
        else if (collision.gameObject.tag == "Enemy3")
        {
            Destroy(bullet);
            enemyPlayer3.health -= 50;
        }
    }
}