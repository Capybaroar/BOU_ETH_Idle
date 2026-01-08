using System.Collections;
using UnityEngine;

public class AlliesDommage : MonoBehaviour
{
    public EnnemyValue MonsterLife;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    public IEnumerator MyCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            MonsterLife.Life -= 1;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
