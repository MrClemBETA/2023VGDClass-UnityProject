using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterFollow : MonoBehaviour
{
    public Transform LateefPoint;
    public Transform MeresankhPoint;
    public Transform TheOriginalAndrew;
    private NavMeshAgent Lateef;
    private NavMeshAgent Meresankh;
    private NavMeshAgent Enemy;
    public float detectionRadius = 5f;
    
    private void Start()
    {
        Lateef = GetComponent<NavMeshAgent>();
        Meresankh = GetComponent<NavMeshAgent>();
        Enemy = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(TheOriginalAndrew.position, transform.position);
        Lateef.destination = LateefPoint.position;
        Meresankh.destination = MeresankhPoint.position;
        if (distance <= detectionRadius)
        {
            Enemy.destination = TheOriginalAndrew.position;
        }

    }
}
