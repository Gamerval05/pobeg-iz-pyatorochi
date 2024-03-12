using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPS : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent agent;

    private void Start()
    {
        agent= GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination= player.transform.position;
    }
}
