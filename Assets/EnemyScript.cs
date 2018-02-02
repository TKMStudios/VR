using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyScript : MonoBehaviour
{

    public EnemyPlayers enemy1;
    public EnemyPlayers enemy2;
    public EnemyPlayers enemy3;

    public GameObject enemyObject1;
    public GameObject enemyObject2;
    public GameObject enemyObject3;

    public TextMeshProUGUI enemyHealth;
    public TextMeshProUGUI enemyHealth2;
    public TextMeshProUGUI enemyHealth3;

    public TextMeshProUGUI enemyName1;
    public TextMeshProUGUI enemyName2;
    public TextMeshProUGUI enemyName3;

    // Use this for initialization
    void Start()
    {
        enemyName1.text = enemy1.name;
        enemyName2.text = enemy2.name;
        enemyName3.text = enemy3.name;  
    }

    // Update is called once per frame
    void Update()
    {
        enemyHealth.text = enemy1.health.ToString();
        enemyHealth2.text = enemy2.health.ToString();
        enemyHealth3.text = enemy3.health.ToString();

        if (enemy1.health == 0)
        {
            Destroy(enemyObject1);
        }
        else if (enemy2.health == 0)
        {
            Destroy(enemyObject2);
        }
        else if (enemy3.health == 0)
        {
            Destroy(enemyObject3);
        }
    }
}
