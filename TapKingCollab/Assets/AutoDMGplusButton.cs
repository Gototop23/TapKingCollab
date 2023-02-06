using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoDMGplusButton : MonoBehaviour
{

    ClickDamage ClickDamageScript;  
    LevelPoints_Script LevelPointsCount;
    AutoDMGminButton PointsReverted;

    public Text IncreaseAutoDMGby10Text;
    
    public int LevelPointsSpended;




    // Start is called before the first frame update
    void Start()
    {
        IncreaseAutoDMGby10Text = GameObject.Find("AutoDMGplusCounter").GetComponent<Text>();
        gameObject.GetComponent<Button>().onClick.AddListener(IncreaseAutoDMGBy10);
        LevelPointsSpended = 0;
    }

    private void IncreaseAutoDMGBy10()
    {
        LevelPointsCount = FindObjectOfType<LevelPoints_Script>();
        PointsReverted = FindObjectOfType<AutoDMGminButton>();

        if(LevelPointsCount.LevelPoints > (0))
        {
            ClickDamageScript = FindObjectOfType<ClickDamage>();
            ClickDamageScript.AutoDMG = ClickDamageScript.AutoDMG + 0.5f;

            LevelPointsSpended += 1;
            PointsReverted.LevelPointsReverted += 1;


        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
