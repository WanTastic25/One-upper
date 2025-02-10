using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyStats : MonoBehaviour
{
    public Image enemyHPBar;
    public Image enemyEgoBar;

    public float enemyCurrentHP;
    public float enemyMaxHP = 100;

    public float enemyCurrentEgo;
    public float enemyMaxEgo = 30;

    // Start is called before the first frame update
    void Start()
    {
        GameObject hpBarObj = GameObject.Find("enemyHealth");
        GameObject EgoBarObj = GameObject.Find("enemyEgo");

        enemyHPBar = hpBarObj.GetComponent<Image>();
        enemyEgoBar = EgoBarObj.GetComponent<Image>();

        enemyCurrentHP = enemyMaxHP;
        enemyCurrentEgo = enemyMaxEgo;
    }

    // Update is called once per frame
    void Update()
    {
        enemyHPBar.fillAmount = enemyCurrentHP / enemyMaxHP;
        enemyEgoBar.fillAmount = enemyCurrentEgo / enemyMaxEgo;

        if (enemyHPBar.fillAmount <= 0)
        {
            enemyDying();
        }
    }

    public void enemyDying()
    {
        FindObjectOfType<audioManager>().Play("enemyDie");
        Destroy(gameObject);
    }
}
