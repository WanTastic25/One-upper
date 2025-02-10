using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{
    public Image playerHPBar;
    public Image playerEgoBar;

    public float playerCurrentHP;
    public float playerMaxHP = 100;

    public float playerCurrentEgo;
    public float playerMaxEgo = 30;

    void Start()
    {
        GameObject hpBarObj = GameObject.Find("health");
        GameObject EgoBarObj = GameObject.Find("ego");

        playerHPBar = hpBarObj.GetComponent<Image>();
        playerEgoBar = EgoBarObj.GetComponent<Image>();

        playerCurrentHP = playerMaxHP;
        playerCurrentEgo = playerMaxEgo;
    }

    private void Update()
    {
        playerHPBar.fillAmount = playerCurrentHP / playerMaxHP;
        playerEgoBar.fillAmount = playerCurrentEgo / playerMaxEgo;
    }
}
