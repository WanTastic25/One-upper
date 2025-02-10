using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class cardDisplay : MonoBehaviour
{
    public card cardData;
    private SpriteRenderer spriteRenderer;

    //public TMP_Text nameText;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Setup(card card)
    {
        cardData = card;
        spriteRenderer.sprite = card.cardSprite;
        Debug.Log(card.cardName);
    }

    public string GetCardName()
    {
        return cardData.cardName;
    }
}
