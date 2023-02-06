using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CritplusButton : MonoBehaviour
{

    ClickDamage ClickDamageScript;  
    LevelPoints_Script LevelPointsCount;
    CritminButton PointsReverted;

    public Text IncreaseCRITby10Text;

    public int LevelPointsSpended;




    // Start is called before the first frame update
    void Start()
    {
        IncreaseCRITby10Text = GameObject.Find("CritplusCounter").GetComponent<Text>();
        gameObject.GetComponent<Button>().onClick.AddListener(IncreaseCRITBy10);
        LevelPointsSpended = 0;
    }

    private void IncreaseCRITBy10()
    {
        LevelPointsCount = FindObjectOfType<LevelPoints_Script>();
        PointsReverted = FindObjectOfType<CritminButton>();
        ClickDamageScript = FindObjectOfType<ClickDamage>();

        if(ClickDamageScript.critChance < (1))
        {

        if(LevelPointsCount.LevelPoints > (0))
        {
            ClickDamageScript = FindObjectOfType<ClickDamage>();
            ClickDamageScript.critChance = ClickDamageScript.critChance + 0.001f;

            LevelPointsSpended += 1;
            PointsReverted.LevelPointsReverted += 1;


        }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
