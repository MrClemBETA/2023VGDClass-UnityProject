using Cinemachine;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

namespace SOS.AndrewsAdventure.Character
{

    /// AM = Attack Multiplier, the amount of damage a character's attack is mutiplied by
    /// BA = Bonus Attack, additional damage that isn't affected by the damage calculation
    /// DD = Defense Divider, the value an attack's total damage is divided by
    /// BD = Bonus Defense, additional defense that isn't affected by the defense divider
    [RequireComponent(typeof(Health))]
    public class BattleManager : MonoBehaviour
    {
        private bool inBattle = false;
        private Party.Party party;
        public CinemachineVirtualCamera vCamera3rdPerson;
        [SerializeField] Transform LateefPoint;
        [SerializeField] Transform MeresankhPoint;
        public NavMeshAgent Boulderdash;
        [SerializeField] Transform TheOriginalAndrew;

        public void Start()
        {
            party = FindAnyObjectByType<Party.Party>();
            Boulderdash = GetComponent<NavMeshAgent>();
        }
        public void OnTriggerEnter(Collider collider)
        {
            if (collider.tag == "Player")
            {
                inBattle = true;
            }
        }

        public void Update() 
        {
            Boulderdash.destination = TheOriginalAndrew.position;
            if (inBattle == true)
            {
                vCamera3rdPerson.Priority = 1;
                party.MoveParty(new Vector3(-3f, 2.31f, 102f));
                transform.position = new Vector3(3f, 2.31f, 102f);
                LateefPoint.position = new Vector3(-5f, 1.5f, 100f);
                MeresankhPoint.position = new Vector3(-7f, 1.5f, 98f);
            }
        }
    }
}

    