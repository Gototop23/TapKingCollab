using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CritminButton : MonoBehaviour
{

    ClickDamage ClickDamageScript;  
    LevelPoints_Script LevelPointsCount2;
    CritplusButton PointsSpended;


    public Text DecreaseCRITby10Text;

    public int LevelPointsReverted;




    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(DecreaseCRITBy10);
        DecreaseCRITby10Text = GameObject.Find("CritplusCounter").GetComponent<Text>();
        LevelPointsReverted = 0;


    }

    



    private void DecreaseCRITBy10()
    {
        PointsSpended = FindObjectOfType<CritplusButton>();
        ClickDamageScript = FindObjectOfType<ClickDamage>();

        if(LevelPointsReverted > (0))
        {
            ClickDamageScript.critChance = ClickDamageScript.critChance - 0.001f;
            DecreaseCRITby10Text.text = ClickDamageScript.critChance.ToString();

            LevelPointsReverted -= 1;
            PointsSpended.LevelPointsSpended -= 1;

        }
       
    }

}