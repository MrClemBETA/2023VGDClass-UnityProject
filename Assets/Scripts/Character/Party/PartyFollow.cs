using UnityEngine;
using UnityEngine.AI;

namespace SOS.AndrewsAdventure.Character.Party
{
    public class PartyFollow : MonoBehaviour
    {
        [SerializeField] Transform target;
        [SerializeField] float speed;

        private NavMeshAgent agent;

        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            agent.speed = speed;
        }

        // Update is called once per frame
        void Update()
        {
            agent.destination = target.position;
        }

        public void SetTarget(Transform target) { this.target = target; }
    }
}
