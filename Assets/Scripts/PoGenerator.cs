using UnityEngine;
using TMPro;

public class PoGenerator : MonoBehaviour
{
    public float goldAmount;
    public TextMeshProUGUI goldText;
    public AttackForce force;

    private float Dommage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Dommage = force.power;
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = goldAmount.ToString();
    }
}
