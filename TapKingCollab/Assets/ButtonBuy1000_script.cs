using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ButtonBuy1000_script : MonoBehaviour
{
    public Enemy_Script CurrencyAmount;

    public int total;
    public int randomNumber;

    public Button ButtonBuy1000;

    public item1_Script item1;
    public item2_Script item2;
    public item3_Script item3;

    public ClickDamage ClickDamageScript;

    public Enemy_Script CurrencyCount;


    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(BuyItem1000);

    }

    
    void Update()
    {
    CurrencyCount = FindObjectOfType<Enemy_Script>();

    if(CurrencyCount.Currency >= 1000)
    {
      ButtonBuy1000.interactable = true;
    }
    else 
    {
        ButtonBuy1000.interactable = false;
    }
    }

    void BuyItem1000()
    {
        CurrencyAmount = FindObjectOfType<Enemy_Script>();

        ClickDamageScript = FindObjectOfType<ClickDamage>();

        item1 = FindObjectOfType<item1_Script>();
        item2 = FindObjectOfType<item2_Script>();
        item3 = FindObjectOfType<item3_Script>();

        

        if (CurrencyAmount.Currency >= 1000);
        {
            CurrencyAmount.Currency -= 1000;
            Debug.Log ("bought Gear");

            randomNumber = Random.Range(0, 149);

            if (randomNumber > 0 && randomNumber < 50)
            {
                    Debug.Log ("award giant pointer dmg"); 
                    item1.Amount += 1;
                    ClickDamageScript.damagePerClick += 1;

            }
            if (randomNumber > 49 && randomNumber < 100)
            {
                    Debug.Log ("award giant pointer auto dmg");
                    item2.Amount += 1;
                    ClickDamageScript.AutoDMG += 0.5f;
            }
            if (randomNumber > 99 && randomNumber < 150)
            {
                    Debug.Log ("award giant pointer crit dmg");
                    item3.Amount += 1;
                    ClickDamageScript.critDMG += 0.01f;
            }
            
            }

        }

    
}


