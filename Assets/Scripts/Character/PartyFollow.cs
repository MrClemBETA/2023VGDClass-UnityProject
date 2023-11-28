using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PartyFollow : MonoBehaviour
{
    public Transform LateefPoint;
    public Transform MeresankhPoint;
    private NavMeshAgent Lateef;
    private NavMeshAgent Meresankh;
    
    private void Start()
    {
        Lateef = GetComponent<NavMeshAgent>();
        Meresankh = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Lateef.destination = LateefPoint.position;
        Meresankh.destination = MeresankhPoint.position;
        
    }
}
