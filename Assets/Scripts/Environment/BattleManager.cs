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

        public void Start()
        {
            party = FindAnyObjectByType<Party.Party>();
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
            if (inBattle == true)
            {
                party.MoveParty(new Vector3(-3f, 2.31f, 102f));
                transform.position = new Vector3(3f, 2.31f, 102f);
                vCamera3rdPerson.Priority = 1;
            }
        }
    }
}

    