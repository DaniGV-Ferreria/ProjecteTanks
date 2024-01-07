using System.Transactions;
using System.Threading.Tasks.Dataflow;
using System.Reflection.Metadata;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Ai;
public class EnemyMovement : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target= GameObject.FindGameObjectWihtTag("Player").transform;
        agent= GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
