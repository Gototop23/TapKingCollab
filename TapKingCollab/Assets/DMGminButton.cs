using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DMGminButton : MonoBehaviour
{

    ClickDamage ClickDamageScript;  
    LevelPoints_Script LevelPointsCount2;
    DMGplusButton PointsSpended;


    public Text DecreaseDMGby10Text;

    public int LevelPointsReverted;




    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(DecreaseDMGBy10);
        DecreaseDMGby10Text = GameObject.Find("DMGplusCounter").GetComponent<Text>();
        LevelPointsReverted = 0;


    }

    



    private void DecreaseDMGBy10()
    {
        PointsSpended = FindObjectOfType<DMGplusButton>();
        ClickDamageScript = FindObjectOfType<ClickDamage>();

        if(LevelPointsReverted > (0))
        {
            ClickDamageScript.damagePerClick = ClickDamageScript.damagePerClick - 1;
            DecreaseDMGby10Text.text = ClickDamageScript.damagePerClick.ToString();

            LevelPointsReverted -= 1;
            PointsSpended.LevelPointsSpended -= 1;

        }
       
    }

}