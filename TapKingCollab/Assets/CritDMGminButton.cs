using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CritDMGminButton : MonoBehaviour
{

    ClickDamage ClickDamageScript;  
    LevelPoints_Script LevelPointsCount2;
    CritDMGplusButton PointsSpended;


    public Text DecreaseCritDMGby10Text;

    public int LevelPointsReverted;




    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(DecreaseCritDMGBy10);
        DecreaseCritDMGby10Text = GameObject.Find("CritDMGplusCounter").GetComponent<Text>();
        LevelPointsReverted = 0;


    }

    



    private void DecreaseCritDMGBy10()
    {
        PointsSpended = FindObjectOfType<CritDMGplusButton>();
        ClickDamageScript = FindObjectOfType<ClickDamage>();

        if(LevelPointsReverted > (0))
        {
            ClickDamageScript.critDMG = ClickDamageScript.critDMG - 0.01f;
            DecreaseCritDMGby10Text.text = ClickDamageScript.critDMG.ToString();

            LevelPointsReverted -= 1;
            PointsSpended.LevelPointsSpended -= 1;

        }
       
    }

}
