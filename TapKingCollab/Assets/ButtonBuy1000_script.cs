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

    public item1_Script item1;

    public ClickDamage ClickDamageScript;



    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(BuyItem1000);

    }

    void BuyItem1000()
    {
        CurrencyAmount = FindObjectOfType<Enemy_Script>();

        ClickDamageScript = FindObjectOfType<ClickDamage>();

        item1 = FindObjectOfType<item1_Script>();

        

        if (CurrencyAmount.Currency >= 1000);
        {
            CurrencyAmount.Currency -= 1000;
            Debug.Log ("bought Gear");

            randomNumber = Random.Range(0, 200);

            if (randomNumber > 20 && randomNumber < 50)
            {
                    Debug.Log ("award giant pointer"); 
                    item1.Amount += 1;
                    ClickDamageScript.AutoDMG += 1;

            }

            }

        }

    
}


