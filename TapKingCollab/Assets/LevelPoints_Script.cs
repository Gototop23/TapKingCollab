using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelPoints_Script : MonoBehaviour
{

    public GameObject LevelPointsOverlay;
    public GameObject DMGplus;
    public GameObject DMGmin;
    public GameObject DMGplusCounter;
    public GameObject Critplus;
    public GameObject Critmin;
    public GameObject CritplusCounter;
    public GameObject AutoDMGplus;
    public GameObject AutoDMGmin;
    public GameObject AutoDMGplusCounter;
    public GameObject CritDMGplus;
    public GameObject CritDMGmin;
    public GameObject CritDMGplusCounter;

    public bool LevelPointsOverlayIsEnabled;
    public bool DMGminIsEnabled;
    public bool DMGplusIsEnabled;
    public bool DMGplusCounterIsEnabled;
    public bool CritminIsEnabled;
    public bool CritplusIsEnabled;
    public bool CritplusCounterIsEnabled;
    public bool AutoDMGplusIsEnabled;
    public bool AutoDMGminIsEnabled;
    public bool AutoDMGplusCounterIsEnabled;
    public bool CritDMGplusIsEnabled;
    public bool CritDMGminIsEnabled;
    public bool CritDMGplusCounterIsEnabled;

    public int LevelPointsP1;
    public int LevelPointsP2;

    public int LevelPoints;

    public Text CurrentLevelPointsText;

    public Button ButtonDMGmin;
    public Button ButtonDMGplus;
    public Button ButtonCRITmin;
    public Button ButtonCRITplus;
    public Button ButtonDMGautomin;
    public Button ButtonDMGautoplus;
    public Button ButtonCritDMGmin;
    public Button ButtonCritDMGplus;

    
    Enemy_Script BossLevelPoints;
    DMGplusButton LevelPointsSpended2;
    DMGminButton LevelPointsReverted2;
    CritplusButton LevelPointsSpended3;
    CritminButton LevelPointsReverted3;
    AutoDMGplusButton LevelPointsSpended4;
    AutoDMGminButton LevelPointsReverted4;
    CritDMGplusButton LevelPointsSpended5;
    CritDMGminButton LevelPointsReverted5;
    ClickDamage ClickDamageScript;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);

        CurrentLevelPointsText = GameObject.Find("Level Points Remaining Number").GetComponent<Text>();




        LevelPointsOverlayIsEnabled = false;
        LevelPointsOverlay.SetActive(LevelPointsOverlayIsEnabled);
        
        DMGminIsEnabled = false;
        DMGmin.SetActive(DMGminIsEnabled);

        DMGplusIsEnabled = false;
        DMGplus.SetActive(DMGplusIsEnabled);

        DMGplusCounterIsEnabled = false;
        DMGplusCounter.SetActive(DMGplusCounterIsEnabled);

        CritminIsEnabled = false;
        Critmin.SetActive(CritminIsEnabled);

        CritplusIsEnabled = false; 
        Critplus.SetActive(CritplusIsEnabled);

        CritplusCounterIsEnabled = false;
        CritplusCounter.SetActive(CritplusCounterIsEnabled);

        AutoDMGplusIsEnabled = false;
        AutoDMGplus.SetActive(AutoDMGplusIsEnabled);

        AutoDMGminIsEnabled = false;
        AutoDMGmin.SetActive(AutoDMGminIsEnabled);

        AutoDMGplusCounterIsEnabled = false;
        AutoDMGplusCounter.SetActive(AutoDMGplusCounterIsEnabled);

        CritDMGplusIsEnabled = false;
        CritDMGplus.SetActive(CritDMGplusIsEnabled);

        CritDMGminIsEnabled = false;
        CritDMGmin.SetActive(CritDMGminIsEnabled);

        CritDMGplusCounterIsEnabled = false;
        CritDMGplusCounter.SetActive(CritDMGplusCounterIsEnabled);


    }

    private void TurnOnAndOff()
    {
        LevelPointsOverlayIsEnabled ^= true;
        LevelPointsOverlay.SetActive(LevelPointsOverlayIsEnabled);

        DMGminIsEnabled ^= true;
        DMGmin.SetActive(DMGminIsEnabled);

        DMGplusIsEnabled ^= true;
        DMGplus.SetActive(DMGplusIsEnabled);

        DMGplusCounterIsEnabled ^= true;
        DMGplusCounter.SetActive(DMGplusCounterIsEnabled);

        CritminIsEnabled ^= true;
        Critmin.SetActive(CritminIsEnabled);

        CritplusIsEnabled ^= true; 
        Critplus.SetActive(CritplusIsEnabled);

        CritplusCounterIsEnabled ^= true;
        CritplusCounter.SetActive(CritplusCounterIsEnabled);

        AutoDMGplusIsEnabled ^= true;
        AutoDMGplus.SetActive(AutoDMGplusIsEnabled);

        AutoDMGminIsEnabled ^= true;
        AutoDMGmin.SetActive(AutoDMGminIsEnabled);

        AutoDMGplusCounterIsEnabled ^= true;
        AutoDMGplusCounter.SetActive(AutoDMGplusCounterIsEnabled);

        CritDMGplusIsEnabled ^= true;
        CritDMGplus.SetActive(CritDMGplusIsEnabled);

        CritDMGminIsEnabled ^= true;
        CritDMGmin.SetActive(CritDMGminIsEnabled);
        
        CritDMGplusCounterIsEnabled ^= true;
        CritDMGplusCounter.SetActive(CritDMGplusCounterIsEnabled);

    }

    // Update is called once per frame
    void Update()
    {
        BossLevelPoints = FindObjectOfType<Enemy_Script>();
        LevelPointsSpended2 = FindObjectOfType<DMGplusButton>();
        LevelPointsReverted2 = FindObjectOfType<DMGminButton>();
        LevelPointsSpended3 = FindObjectOfType<CritplusButton>();
        LevelPointsReverted3 =  FindObjectOfType<CritminButton>();
        LevelPointsSpended4 = FindObjectOfType<AutoDMGplusButton>();
        LevelPointsReverted4 = FindObjectOfType<AutoDMGminButton>();
        LevelPointsSpended5 = FindObjectOfType<CritDMGplusButton>();
        LevelPointsReverted5 = FindObjectOfType<CritDMGminButton>();

        ClickDamageScript = FindObjectOfType<ClickDamage>();


        LevelPoints = LevelPointsP1; 
        LevelPointsP1 = BossLevelPoints.bossLevel - LevelPointsSpended2.LevelPointsSpended - LevelPointsSpended3.LevelPointsSpended - LevelPointsSpended4.LevelPointsSpended - LevelPointsSpended5.LevelPointsSpended;
        CurrentLevelPointsText.text = LevelPoints.ToString();


        if (LevelPointsReverted2.LevelPointsReverted > 0)
        {
            ButtonDMGmin.interactable = true;
        }
        else
        {
            ButtonDMGmin.interactable = false;
        }


        if (LevelPoints > 0)
        {
            ButtonDMGplus.interactable = true;
        }
        else
        {
            ButtonDMGplus.interactable = false;
        }

        
        if (LevelPointsReverted3.LevelPointsReverted > 0)
        {
            ButtonCRITmin.interactable = true;
        }
        else
        {
            ButtonCRITmin.interactable = false;
        }

        
        if (LevelPoints > 0)
        {
            ButtonCRITplus.interactable = true;
        }
        else
        {
            ButtonCRITplus.interactable = false;
        }

        if(LevelPointsReverted4.LevelPointsReverted > 0)
        {
            ButtonDMGautomin.interactable = true;
        }
        else
        {
            ButtonDMGautomin.interactable = false;
        }

        if (LevelPoints > 0)
        {
            ButtonDMGautoplus.interactable = true;
        }
        else 
        {
            ButtonDMGautoplus.interactable = false;
        }

        if(LevelPointsReverted5.LevelPointsReverted > 0)
        {
            ButtonCritDMGmin.interactable = true;
        }
        else
        {
            ButtonCritDMGmin.interactable = false;
        }

        if (LevelPoints > 0)
        {
            ButtonCritDMGplus.interactable = true;
        }
        else 
        {
            ButtonCritDMGplus.interactable = false;
        }

        

}

}