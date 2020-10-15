using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    public UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = target.position;
    }
    
}
