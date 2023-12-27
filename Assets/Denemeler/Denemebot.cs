using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Denemebot : MonoBehaviour
{
    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Tunahan();
        }
    }

    private void Tunahan()
    {
        agent.Move(new Vector3(3, 0, 0));
    }
}
