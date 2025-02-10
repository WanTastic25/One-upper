using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class cardHolder : MonoBehaviour
{
    public Transform[] cardHoldPos;

    public GameObject[] cardPrefab;

    private void Start()
    {
        StartCoroutine(SpawnCard());
    }

    public void OnButtonClicked()
    {
        StartCoroutine(SpawnCard());
    }

    public IEnumerator SpawnCard()
    {
        FindObjectOfType<audioManager>().Play("cardSpawn");

        for (int i = 0; i < 5; i++)
        {
            int r = Random.Range(0,7);

            Instantiate(cardPrefab[r], cardHoldPos[i]);
        }

        yield return new WaitForSeconds(1f);
    }

    public void deleteCards()
    {
        GameObject[] cardsToDelete = GameObject.FindGameObjectsWithTag("Card");
        FindObjectOfType<audioManager>().Play("cardDeleted");

        foreach (GameObject card in cardsToDelete)
        {
            Destroy(card);
        }
    }
}
