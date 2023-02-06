using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ButtonBuy1000_script : MonoBehaviour
{
    public Enemy_Script CurrencyAmount;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(BuyItem1000);
    }

    void BuyItem1000()
    {
        CurrencyAmount = FindObjectOfType<Enemy_Script>();

        if (CurrencyAmount.Currency >= 1000);
        {
            CurrencyAmount.Currency -= 1000;
            Debug.Log ("bought Gear");

        }
    
}

}

