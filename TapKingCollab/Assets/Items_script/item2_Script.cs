using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item2_Script : MonoBehaviour
{
    public int Amount;
    public GameObject Item2Count;
    public Text item2Count;



    void Start()
    {
        item2Count = GameObject.Find("Item 2 count").GetComponent<Text>();
    }

    private void Update()
    {
        item2Count.text = Amount.ToString();
    }
}
