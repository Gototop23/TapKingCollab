using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DMGplusButton : MonoBehaviour
{

    ClickDamage ClickDamageScript;  
    LevelPoints_Script LevelPointsCount;
    DMGminButton PointsReverted;

    public Text IncreaseDMGby10Text;

    public int LevelPointsSpended;




    // Start is called before the first frame update
    void Start()
    {
        IncreaseDMGby10Text = GameObject.Find("DMGplusCounter").GetComponent<Text>();
        gameObject.GetComponent<Button>().onClick.AddListener(IncreaseDMGBy10);
        LevelPointsSpended = 0;
    }

    private void IncreaseDMGBy10()
    {
        LevelPointsCount = FindObjectOfType<LevelPoints_Script>();
        PointsReverted = FindObjectOfType<DMGminButton>();

        if(LevelPointsCount.LevelPoints > (0))
        {
            ClickDamageScript = FindObjectOfType<ClickDamage>();
            ClickDamageScript.damagePerClick = ClickDamageScript.damagePerClick + 1;
            IncreaseDMGby10Text.text = ClickDamageScript.damagePerClick.ToString();

            LevelPointsSpended += 1;
            PointsReverted.LevelPointsReverted += 1;


        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
