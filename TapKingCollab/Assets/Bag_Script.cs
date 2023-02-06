using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag_Script : MonoBehaviour
{

    public GameObject BagOverlay;

    public bool BagOverlayIsEnabled;


    public Text Item1AmountText;
    public Text Item2AmountText;
    public Text Item3AmountText;
    public Text Item4AmountText;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);

        BagOverlayIsEnabled = false;
        BagOverlay.SetActive(BagOverlayIsEnabled);

        Item1AmountText = GameObject.Find("Item1AmountText").GetComponent<Text>();
        Item1AmountText = GameObject.Find("Item2AmountText").GetComponent<Text>();
        Item1AmountText = GameObject.Find("Item3AmountText").GetComponent<Text>();
        Item1AmountText = GameObject.Find("Item4AmountText").GetComponent<Text>();

    }   

     private void TurnOnAndOff()
    {
        BagOverlayIsEnabled ^= true;
        BagOverlay.SetActive(BagOverlayIsEnabled);
    }


    void Update()
    {

      //  Item1AmountText = ItemAmount.Amount;
    }
}
