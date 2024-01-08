using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject tankEnemyPrefab;
    public Transform[] positionsEnemy;
    public float time;
    public Transform parentEnemies;

    void Start()
    {
        InvokeRepeating("CreateEnemies", time, time);
    }

    void CreateEnemies()
    {
        int n = UnityEngine.Random.Range(0, positionsEnemy.Length);
        GameObject cloneTankEnemy = Instantiate(tankEnemyPrefab, positionsEnemy[n].position, positionsEnemy[n].rotation);

        // Asigna el GameManager al script EnemyMovement en la instancia creada
        EnemyMovement enemyMovement = cloneTankEnemy.GetComponent<EnemyMovement>();
        if (enemyMovement != null)
        {
            enemyMovement.gameManager = FindObjectOfType<GameManager>(); // Encuentra el GameManager en la escena
        }

        cloneTankEnemy.transform.SetParent(parentEnemies);
    }

}
