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
        private Transform player;
        private Party.Party party;
        private Transform Meresankh;
        private Transform Lateef;
        public CinemachineVirtualCamera vCamera3rdPerson;
        private NavMeshAgent nma;

        public void Start()
        {
            player = FindAnyObjectByType<PlayerController>().transform;
            party = FindAnyObjectByType<Party.Party>();
            Meresankh = party.GetCharacter("Meresankh").transform;
            Lateef = party.GetCharacter("Lateef").transform;
            nma = GetComponent<NavMeshAgent>();
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
            nma.destination = player.position;

            if (inBattle == true)
            {
                player.position = new Vector3(-3f, 2.31f, 102f);
                transform.position = new Vector3(3f, 2.31f, 102f);
                Lateef.position = new Vector3(-4f, 1f, 100f);
                Meresankh.position = new Vector3(-5f, 1f, 98);
                vCamera3rdPerson.Priority = 1;
            }
        }
    }
}

    