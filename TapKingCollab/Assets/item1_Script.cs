using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item1_Script : MonoBehaviour
{
    public int Amount;
    public GameObject Item1Count;
    public Text item1Count;

    void Start()
    {
        item1Count = GameObject.Find("Item 1 count").GetComponent<Text>();
    }

    private void Update()
    {
        item1Count.text = Amount.ToString();
    }
}
