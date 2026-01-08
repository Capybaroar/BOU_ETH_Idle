using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;



public class AlliesSpawner : MonoBehaviour
{
    public List<GameObject> AlliesSpawn;
    public PoGenerator Po;
    public TextMeshProUGUI AlliesPrice;
    public float price;
    public int MinionSpawn;
    public AlliesDommage Lacourououquoila;
    void Start()
    {

    }

    public void Creepspawn()
    {

        if (Po.goldAmount >= price)
        {
            
            Po.goldAmount -= price;
            AlliesSpawn[MinionSpawn].SetActive(true);
            MinionSpawn++;
            price *= 1.2f;
            AlliesPrice.text = price.ToString() + " Po to get Allies";
            StartCoroutine(Lacourououquoila.MyCoroutine());


        }


    }
}
