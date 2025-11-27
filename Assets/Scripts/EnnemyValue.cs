using UnityEngine;
using UnityEngine.UI;

public class EnnemyValue : MonoBehaviour
{
    public int Value;
    public int Life;
    public PoGenerator poGenerator;
    private int StartLife;
    public Image SbireIMG;
    public Image CanonIMG;
    private int valAleatoir;
    public Sprite SbireSprite;
    public Sprite CanonSprite;
    public void Dammage()
    {
        StartLife=Life;
        Life -= 1;
        if(Life<=0)
        {
            poGenerator.goldAmount += Value;
            valAleatoir = Random.Range(0, 1);
            if (valAleatoir == 0)
            {
                SbireIMG.sprite = SbireSprite;
            }
            else
            {
                CanonIMG.sprite = CanonSprite;
            }
        }
    }


    public void LifeManager()
    {
        if (valAleatoir == 0)
        {
            Life = 50;
        }
        else
        {
            Life = 150;
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
