using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]

public class card : ScriptableObject
{
    public string cardName;
    public CardType cardType;
    public int egoDmg;
    public int healthDmg;
    public int egoCost;
    public int shieldAmnt;
    public Sprite cardSprite;

    public enum CardType
    {
        Violent,
        Emotional,
        Defence
    }
}
