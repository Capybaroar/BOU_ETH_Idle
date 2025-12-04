using UnityEngine;
using UnityEngine.UI;

public class EnnemyValue : MonoBehaviour
{
    public float Life;
    public PoGenerator poGenerator;
    public Image ennemyIMG;
    public Sprite SbireSprite;
    public Sprite CanonSprite;
    public AttackForce attack;

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
            valAleatoir = Random.Range(0, 2);
            if (valAleatoir == 0)
            {
                ennemyIMG.sprite = SbireSprite;
                Life = 50;
                Value = 5;
            }
            else
            {
                ennemyIMG.sprite = CanonSprite;
                Life = 150;
                Value = 15;
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
