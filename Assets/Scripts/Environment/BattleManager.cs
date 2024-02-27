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
        public CinemachineVirtualCamera vCamera3rdPerson;
        [SerializeField] Transform battlePlayerLocation;
        [SerializeField] Transform battleEnemiesLocation;
        [SerializeField] Transform playerLocation;
        [SerializeField] float range = 15f;
        private bool inBattle = false;
        private Party.Party party;
        public NavMeshAgent Boulderdash;

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
            print((Vector3.Distance(playerLocation.position, transform.position)));
            if (Vector3.Distance(playerLocation.position, transform.position) <= range)
            {
                Boulderdash.destination = playerLocation.position;
            }
            if (inBattle == true)
            {
                vCamera3rdPerson.Priority = 1;
                party.MoveParty(battlePlayerLocation.position);
                transform.position = battleEnemiesLocation.position;
            }
        }
    }
}

    