using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AutoDMGminButton : MonoBehaviour
{

    ClickDamage ClickDamageScript;  
    LevelPoints_Script LevelPointsCount2;
    AutoDMGplusButton PointsSpended;


    public Text DecreaseAutoDMGby10Text;
    public int LevelPointsReverted;




    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(DecreaseAutoDMGBy10);
        DecreaseAutoDMGby10Text = GameObject.Find("AutoDMGplusCounter").GetComponent<Text>();
        LevelPointsReverted = 0;


    }

    



    private void DecreaseAutoDMGBy10()
    {
        PointsSpended = FindObjectOfType<AutoDMGplusButton>();
        ClickDamageScript = FindObjectOfType<ClickDamage>();

        if(LevelPointsReverted > (0))
        {
            ClickDamageScript.AutoDMG = ClickDamageScript.AutoDMG - 0.5f;

            LevelPointsReverted -= 1;
            PointsSpended.LevelPointsSpended -= 1;

        }
       
    }

}
