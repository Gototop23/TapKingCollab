using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ArtifactsButtonBuy_Script : MonoBehaviour
{
    public Enemy_Script CurrencyAmount;

    public int total;
    public int randomNumber;

    public Button ArtifactsButtonBuy1000;

  //  public artifacts1_Script artifacts1;
  //  public artifacts2_Script artifacts2;
  //  public artifacts3_Script artifacts3;

    public ClickDamage ClickDamageScript;

    public Enemy_Script CurrencyCount;



    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(BuyArtifacts);

    }


    void Update()
    {
    CurrencyCount = FindObjectOfType<Enemy_Script>();

    if(CurrencyCount.Currency >= 1000)
    {
        ArtifactsButtonBuy1000.interactable = true;
    }
    else 
    {
        ArtifactsButtonBuy1000.interactable = false;
    }
    }

    void BuyArtifacts()
    {
        CurrencyAmount = FindObjectOfType<Enemy_Script>();

        ClickDamageScript = FindObjectOfType<ClickDamage>();

       // artifacts1 = FindObjectOfType<artifacts1_Script>();
      //  artifacts2 = FindObjectOfType<artifacts2_Script>();
      //  artifacts3 = FindObjectOfType<artifacts3_Script>();

        

        if (CurrencyAmount.Currency >= 1000);
        {
            CurrencyAmount.Currency -= 1000;
            Debug.Log ("bought Gear");

            randomNumber = Random.Range(0, 149);

            if (randomNumber > 0 && randomNumber < 50)
            {
                    Debug.Log ("award giant pointer dmg"); 
               //     item1.Amount += 1;
                //    ClickDamageScript.damagePerClick += 1;

            }
            if (randomNumber > 49 && randomNumber < 100)
            {
                    Debug.Log ("award giant pointer auto dmg");
                //    item2.Amount += 1;
                //    ClickDamageScript.AutoDMG += 0.5f;
            }
            if (randomNumber > 99 && randomNumber < 150)
            {
                    Debug.Log ("award giant pointer crit dmg");
                 //   item3.Amount += 1;
                 //   ClickDamageScript.critDMG += 0.01f;
            }
            
            }

        }
}
