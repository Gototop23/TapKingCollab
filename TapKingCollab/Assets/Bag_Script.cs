using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag_Script : MonoBehaviour
{

    public GameObject BagOverlay;

    public bool BagOverlayIsEnabled;



    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);

        BagOverlayIsEnabled = false;
        BagOverlay.SetActive(BagOverlayIsEnabled);


    }   

     private void TurnOnAndOff()
    {
        BagOverlayIsEnabled ^= true;
        BagOverlay.SetActive(BagOverlayIsEnabled);
    }



}
