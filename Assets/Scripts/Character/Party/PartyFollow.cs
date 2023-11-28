using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace SOS.AndrewsAdventure.Character.Party
{
    public class PartyFollow : MonoBehaviour
    {
        [SerializeField] Transform target;

        private NavMeshAgent agent;

        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            agent.destination = target.position;
        }
    }
}
