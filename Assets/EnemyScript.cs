using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{

    public EnemyPlayers enemyPlayer;

    public Text healthText;
    
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = enemyPlayer.health.ToString();
    }
}
