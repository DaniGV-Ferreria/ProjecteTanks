using System.Transactions;
using System.Threading.Tasks.Dataflow;
using System.Reflection.Metadata;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent= GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(transform.target);
    }
}
