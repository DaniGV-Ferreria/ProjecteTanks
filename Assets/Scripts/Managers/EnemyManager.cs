using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
   public GameObject tankEnemyPrefab;//fa  referrecniaprefab Enemy que volem clonar original
    // Start is called before the first frame update
    public Transform [] EnemyPosition;
    public float time;
    public Transform parentEnemies;
    
    void Start()
    {
        InvokeRepeating("CreateEnemies", time, time);
    }

    // Update is called once per frame
    void CreateEnemies()
    {
        int n = Random.Range(0,EnemyPosition.Length);
        GameObject cloneTankEnemy =Instantiate(tankEnemyPrefab,EnemyPosition[n].position, EnemyPosition[n].rotation);
        cloneTankEnemy.transform.SetParent (parentEnemies);
    }
}


    