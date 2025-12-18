using UnityEngine;
using TMPro;

public class AttackForce : MonoBehaviour
{

    //public TextMeshProUGUI goldText;
    //public TextMeshProUGUI powerTextButton;
    public TextMeshProUGUI DommageAmount;
    public TextMeshProUGUI DommagePrice;
    public float power;
    public PoGenerator pogenerator;
    private float powerPrice;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 1f;
        powerPrice = 10f;
    }

    public void Forcemanager()
    {
        if (pogenerator.goldAmount >= powerPrice)
        {
            pogenerator.goldAmount -= powerPrice;
            power += 1f;
            powerPrice *= 1.2f;
            DommagePrice.text = powerPrice.ToString() + " Po to raise you power";
            DommageAmount.text = power.ToString();
            

        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
