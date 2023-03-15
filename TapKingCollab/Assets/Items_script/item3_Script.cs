using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item3_Script : MonoBehaviour
{
    public int Amount;
    public GameObject Item3Count;
    public Text item3Count;



    void Start()
    {
        item3Count = GameObject.Find("Item 3 count").GetComponent<Text>();
    }

    private void Update()
    {
        item3Count.text = Amount.ToString();
    }
}
