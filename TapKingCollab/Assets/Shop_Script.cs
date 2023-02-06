using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop_Script : MonoBehaviour
{
    public GameObject BuyOverlay;

    public bool BuyOverlayIsEnabled;

    public Button ButtonBuy1000;
    public Button ButtonBuy5000;
    public Button Buttonbuy10000;

    public Enemy_Script CurrencyCount;




    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);

        BuyOverlayIsEnabled = false;
        BuyOverlay.SetActive(BuyOverlayIsEnabled);



    }   

    private void TurnOnAndOff()
    {
        BuyOverlayIsEnabled ^= true;
        BuyOverlay.SetActive(BuyOverlayIsEnabled);
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

        if(CurrencyCount.Currency >= 5000)
        {
            ButtonBuy5000.interactable = true;
        }
        else
        {
            ButtonBuy5000.interactable = false;
        }

        if(CurrencyCount.Currency >= 10000)
        {
            Buttonbuy10000.interactable = true;
        }
        else
        {
            Buttonbuy10000.interactable = false;
        }
    }
}
