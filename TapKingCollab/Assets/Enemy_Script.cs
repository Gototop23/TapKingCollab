using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy_Script : MonoBehaviour
{

   public float Health;
   public float MaxHealth2;
   public float bossLevelAdd2;

   public Sprite[] sprites;

   public GameObject EnemyRef;
   public SpriteRenderer spriteRenderer;

   public float scaleLevel;

   public float scaleLevelStart;

   public float scaleLevelLevel;

   public int bossLevel;
   public Text bossLevelScore;

   public float Currency;
   public Text CurrencyText;









private void Start()
{
   GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];

   MaxHealth2 = Mathf.Pow(10, scaleLevelLevel) * bossLevel;
   Health = MaxHealth2;

   bossLevelScore = GameObject.Find("boss Level Text").GetComponent<Text>();

   spriteRenderer.enabled = true;

   scaleLevelStart = 0;

   scaleLevelLevel = scaleLevelStart + scaleLevel;

   CurrencyText = GameObject.Find("Currency Text").GetComponent<Text>();





}


private void Update()
{
   CurrencyText.text = Currency.ToString();



      if(Health <= 0)
   {
      KillSelf();
   }

      void KillSelf()
   {
      spriteRenderer.enabled = false;
      Invoke("Respawn", 0.0f);

      bossLevel = bossLevel + 1;
      bossLevelScore.text = bossLevel.ToString();

      scaleLevel += 0.01f;

      Currency += bossLevel * 5;



   }

}
   void Respawn()
   {
      GameObject EnemyClone = (GameObject)Instantiate(EnemyRef);
      EnemyClone.transform.position = transform.position;

      EnemyClone.name = "Enemy";


      Destroy(gameObject);
   }




}