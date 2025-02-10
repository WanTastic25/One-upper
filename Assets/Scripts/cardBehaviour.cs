using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardBehaviour : MonoBehaviour
{
    public playerStats playerStats;
    public enemyStats enemyStats;

    public string cName;
    public GameObject playerObj;
    public GameObject enemyObj;
    private cardDisplay clickedCard;

    void Start()
    {
        clickedCard = GetComponent<cardDisplay>();
        playerObj = GameObject.Find("sillybilly(Clone)");
        playerStats = playerObj.GetComponent<playerStats>();

        enemyObj = GameObject.Find("enemy(Clone)");
        enemyStats = enemyObj.GetComponent<enemyStats>();
    }

    private void OnMouseUp()
    {
        if (clickedCard != null && clickedCard.cardData != null)
        {
            if (playerStats.playerCurrentEgo >= clickedCard.cardData.egoCost)
            {
                cName = clickedCard.cardData.cardName;
                playerStats.playerCurrentEgo -= clickedCard.cardData.egoCost;
                enemyStats.enemyCurrentHP -= clickedCard.cardData.healthDmg;
                enemyStats.enemyCurrentEgo -= clickedCard.cardData.egoDmg;

                if (clickedCard.cardData.cardName == "snowflake")
                {
                    FindObjectOfType<audioManager>().Play("santa");
                }
                else
                {
                    FindObjectOfType<audioManager>().Play("cardPlayed");
                }
                Destroy(gameObject);
                Debug.Log("The card is " + cName);
            }
            else if (playerStats.playerCurrentEgo < clickedCard.cardData.egoCost)
            {
                Debug.Log("Not Enough Ego to Cast");
                playerStats.playerCurrentEgo += clickedCard.cardData.egoCost;
            }
        }
    }
}
