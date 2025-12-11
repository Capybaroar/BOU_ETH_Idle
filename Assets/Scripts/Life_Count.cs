using UnityEngine;
using TMPro;

public class Life_Count : MonoBehaviour
{
    public EnnemyValue Lifechanger;
    public TextMeshProUGUI LifeTopTxt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LifeTopTxt.text = Lifechanger.Life.ToString() + " PV";
    }


}
