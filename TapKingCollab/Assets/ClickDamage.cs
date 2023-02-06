 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.EventSystems;
 
 public class ClickDamage : MonoBehaviour
 {

     
     public int damagePerClick;
     public GameObject Enemy;                          // Reference to the enemy GameObject.
     Enemy_Script enemyHealth;                    // Reference to script van enemy health.
     public float critChance;
     public float AutoDMG;
     public Text critChanceText;
     public Text autoDMGText;

    float interval = 0.25f;
    float timer = 0;
    bool autoDamage = true;

    LevelPoints_Script LevelPoints_Script;
    Shop_Script Shop_Script;
    Bag_Script Bag_Script;


     [SerializeField] private GameObject floatingTextPrefab;



     void Awake()
     {
         enemyHealth = Enemy.GetComponent<Enemy_Script>();
        
     }

     void Start()
     {
        damagePerClick = 20;
        critChance = 0.05f;
        AutoDMG = 0;
     }
 
    void IncreaseCritChance(float critInc)
    {
        critChance += critInc;

        if(critChance > 100.0f)
        {
            critChance = 100f;
        }
    }

        



     void Update()
     {

            if (autoDamage)
            {
                timer += Time.deltaTime;
                if (timer >= interval)
                {
                    timer -= interval;
                    enemyHealth.Health -= AutoDMG;
                }
            }

            critChanceText.text = (critChance * 100).ToString();
            autoDMGText.text = AutoDMG.ToString();

            enemyHealth = FindObjectOfType<Enemy_Script>();

             if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
             {
                LevelPoints_Script = FindObjectOfType<LevelPoints_Script>();
                Shop_Script = FindObjectOfType<Shop_Script>();
                Bag_Script = FindObjectOfType<Bag_Script>();

                LevelPoints_Script.LevelPointsOverlayIsEnabled = false;
                LevelPoints_Script.LevelPointsOverlay.SetActive(LevelPoints_Script.LevelPointsOverlayIsEnabled);
        
                LevelPoints_Script.DMGminIsEnabled = false;
                LevelPoints_Script.DMGmin.SetActive(LevelPoints_Script.DMGminIsEnabled);

                LevelPoints_Script.DMGplusIsEnabled = false;
                LevelPoints_Script.DMGplus.SetActive(LevelPoints_Script.DMGplusIsEnabled);

                LevelPoints_Script.DMGplusCounterIsEnabled = false;
                LevelPoints_Script.DMGplusCounter.SetActive(LevelPoints_Script.DMGplusCounterIsEnabled);

                LevelPoints_Script.CritminIsEnabled = false;
                LevelPoints_Script.Critmin.SetActive(LevelPoints_Script.CritminIsEnabled);

                LevelPoints_Script.CritplusIsEnabled = false; 
                LevelPoints_Script.Critplus.SetActive(LevelPoints_Script.CritplusIsEnabled);

                LevelPoints_Script.CritplusCounterIsEnabled = false;
                LevelPoints_Script.CritplusCounter.SetActive(LevelPoints_Script.CritplusCounterIsEnabled);

                LevelPoints_Script.AutoDMGplusIsEnabled = false;
                LevelPoints_Script.AutoDMGplus.SetActive(LevelPoints_Script.AutoDMGplusIsEnabled);

                LevelPoints_Script.AutoDMGminIsEnabled = false;
                LevelPoints_Script.AutoDMGmin.SetActive(LevelPoints_Script.AutoDMGminIsEnabled);

                LevelPoints_Script.AutoDMGplusCounterIsEnabled = false;
                LevelPoints_Script.AutoDMGplusCounter.SetActive(LevelPoints_Script.AutoDMGplusCounterIsEnabled);

                Bag_Script.BagOverlayIsEnabled = false;
                Bag_Script.BagOverlay.SetActive(Bag_Script.BagOverlayIsEnabled);

                Shop_Script.BuyOverlayIsEnabled = false;
                Shop_Script.BuyOverlay.SetActive(Shop_Script.BuyOverlayIsEnabled);

                float randValue = Random.value;
                if(randValue < critChance)
                {
                Debug.Log("did critical attack");
                enemyHealth.Health -= damagePerClick * 2; //damage per click
                ShowDamage((damagePerClick * 2).ToString());
                }
                else
                {
                Debug.Log("did normal attack");
                enemyHealth.Health -= damagePerClick; //damage per click  
                ShowDamage(damagePerClick.ToString());
                }

                }
           }


     void ShowDamage(string text)
     {
        if (floatingTextPrefab)
        { 
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-4, 3), Random.Range(-2, 2.5f), 0);
            GameObject prefab = Instantiate(floatingTextPrefab, randomSpawnPosition, Quaternion.identity);
            prefab.GetComponentInChildren<TextMesh>().text = text;
        }
     }

 }
 

