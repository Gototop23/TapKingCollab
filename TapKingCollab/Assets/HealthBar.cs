using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar: MonoBehaviour
{
    private Image HPBar;
    public float CurrentHealth;
    public float MaxHealth;
    Enemy_Script Enemy;
    public Text bossHPText;
    public Text bossHPMaxText;


    private void Start()
    {


    }

    private void Update()
    {

        bossHPText.text = Mathf.Round(CurrentHealth).ToString();
        bossHPMaxText.text = Mathf.Round(MaxHealth).ToString();


        HPBar = GetComponent<Image>();
        Enemy = FindObjectOfType<Enemy_Script>();
        MaxHealth = Enemy.MaxHealth2;


        MaxHealth = Enemy.MaxHealth2;
        CurrentHealth = Enemy.Health;
        HPBar.fillAmount = CurrentHealth / MaxHealth;

        
    }
}
