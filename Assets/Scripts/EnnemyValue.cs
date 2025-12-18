using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnnemyValue : MonoBehaviour
{
    public float Life;
    public PoGenerator poGenerator;
    public Image ennemyIMG;
    public Sprite SbireSprite;
    public Sprite HeraldSprite;
    public Sprite NashorSprite;
    public Sprite CanonSprite;
    public AttackForce attack;
    public float CreepPoints;
    public float HeraldPoints;
    public float NashorPoints;

    public TextMeshProUGUI KillAmountCreep;
    public TextMeshProUGUI KillAmountHerald;

    public TextMeshProUGUI KillAmountNashor;

    public float StartLife;
    public float valAleatoir;
    public float Value;

    public void Kill()
    {

        StartLife =Life;
        Life -= attack.power;
        print(Value);
        if(Life<=0)
        {
            poGenerator.goldAmount += Value;
            if (valAleatoir <= 60)
            {
                CreepPoints += 1;
                KillAmountCreep.text = CreepPoints.ToString();


            }
            if (valAleatoir > 60 && valAleatoir < 95)
            {
                CreepPoints += 3;
                KillAmountCreep.text = CreepPoints.ToString();



            }
            if (valAleatoir >= 95 && valAleatoir <= 99)
            {
                HeraldPoints += 1;
                KillAmountHerald.text = HeraldPoints.ToString();


            }
            if (valAleatoir == 100)
            {
                NashorPoints += 1;
                KillAmountNashor.text = NashorPoints.ToString();
            }
            valAleatoir = Random.Range(0, 100)+1;
            
            if (valAleatoir <= 60)
            {
                ennemyIMG.sprite = SbireSprite;
                Life = 50;
                Value = 5;
                

            }
            if (valAleatoir > 60 && valAleatoir <95)
            {

                ennemyIMG.sprite = CanonSprite;
                Life = 150;
                Value = 15;
                

            }
            if (valAleatoir >= 95 && valAleatoir <= 99)
            {
                ennemyIMG.sprite = HeraldSprite;
                Life = 1500;
                Value = 200;
                

            }
            if (valAleatoir ==100)
            {
                ennemyIMG.sprite = NashorSprite;
                Life = 10000;
                Value = 2000;
                

            }



        }
    }


    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {    
    }

    // Update is called once per frame
    void Update()
    {
    }
}
