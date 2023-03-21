using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CritDMGplusButton : MonoBehaviour
{

    ClickDamage ClickDamageScript;  
    LevelPoints_Script LevelPointsCount;
    CritDMGminButton PointsReverted;

    public Text IncreaseCritDMGby10Text;

    public int LevelPointsSpended;




    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(IncreaseCritDMGBy10);
        LevelPointsSpended = 0;
    }

        void Update()
    {
    }

    private void IncreaseCritDMGBy10()
    {
        LevelPointsCount = FindObjectOfType<LevelPoints_Script>();
        PointsReverted = FindObjectOfType<CritDMGminButton>();

        if(LevelPointsCount.LevelPoints > (0))
        {
            ClickDamageScript = FindObjectOfType<ClickDamage>();
            ClickDamageScript.critDMG = ClickDamageScript.critDMG + 0.01f;

            LevelPointsSpended += 1;
            PointsReverted.LevelPointsReverted += 1;


        }
       
    }

}
