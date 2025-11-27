using UnityEngine;
using UnityEngine.UI;

public class EnnemyValue : MonoBehaviour
{
    public int Value;
    private int Life;
    public PoGenerator poGenerator;
    private int StartLife;
    public Image SbireIMG;

    public void Dammage()
    {
        StartLife=Life;
        Life -= 1;
        if(Life<=0)
        {
            poGenerator.goldAmount += Value;
            Life = StartLife;
        }
    }


    public void LifeManager()
    {
        if (Image.Source.Image == Siege-Minions_0)
            Life = 200;

        if (Image.Source.Image == Sbire_0)
            Life = 30;

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SbireIMG.
    }
}
