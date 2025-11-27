using UnityEngine;
using TMPro;

public class PoGenerator : MonoBehaviour
{
    public int goldAmount;
    public int Dommage;
    public TextMeshProUGUI goldText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Dommage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = goldAmount.ToString();
    }
}
