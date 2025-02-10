using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WIN, LOSE }

public class battleManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject statBars;
    public GameObject enemystatBars;
    public Transform playerSpawnPos;
    public Transform enemySpawnPos;

    public BattleState state;

    private void Start()
    {
        state = BattleState.START;

        StartCoroutine(battleStart());
    }

    public IEnumerator battleStart()
    {
        //Battle start anims calls can happen here
        //Cards get served to the player
        Debug.Log("Player Spawns");
        Instantiate(player, playerSpawnPos);
        Instantiate(enemy, enemySpawnPos);
        Instantiate(statBars, playerSpawnPos);
        Instantiate(enemystatBars, enemySpawnPos);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    public void PlayerTurn()
    {
        Debug.Log("Player Turn");
    }

    public void EnemyTurn()
    {
        Debug.Log("Enemy Turn");
        //Deal Damage to player
    }
}
