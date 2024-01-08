using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public GameManager gameManager;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (gameManager == null)
        {
            Debug.LogError("GameManager is not assigned to EnemyMovement.");
            enabled = false; // Deshabilitar el script si no hay GameManager asignado.
            return;
        }

        StartCoroutine(UpdateTarget());
    }

    IEnumerator UpdateTarget()
    {
        while (true)
        {
            Transform target = FindClosestPlayer();
            
            if (target != null)
            {
                agent.SetDestination(target.position);
            }

            yield return new WaitForSeconds(1f); 
        }
    }

    Transform FindClosestPlayer()
    {
        Transform[] players = gameManager.GetPlayerTransforms();

        if (players != null && players.Length > 0)
        {
            Transform closestPlayer = players[0];
            float closestDistance = Vector3.Distance(transform.position, players[0].position);

            for (int i = 1; i < players.Length; i++)
            {
                float distance = Vector3.Distance(transform.position, players[i].position);
                if (distance < closestDistance)
                {
                    closestPlayer = players[i];
                    closestDistance = distance;
                }
            }

            return closestPlayer;
        }

        return null;
    }
}

