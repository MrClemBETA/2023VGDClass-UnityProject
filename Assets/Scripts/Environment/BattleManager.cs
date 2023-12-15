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
        [SerializeField] public bool inbattle = false;
        public Transform TheOriginalAndrew;
        public Transform TheFirstOpponent;
        public Transform Meresankh;
        public Transform Lateef;
        public Camera MainCamera;
        public Camera BattleCamera;
        public NavMeshAgent Enemy;

        public void Start()
        {
            Enemy = GetComponent<NavMeshAgent>();
            MainCamera.enabled = true;
            BattleCamera.enabled = false;
            inbattle = false;
        }
        public void OnTriggerEnter(Collider TheFirstOpponent)
        {
            inbattle = true;
        }

        public void Update() 
        {
            Enemy.destination = transform.position;
            
            if (inbattle == true)
            {
                TheOriginalAndrew.position = new Vector3(-3f, 2.31f, 102f);
                TheFirstOpponent.position = new Vector3(3f, 2.31f, 102f);
                Lateef.position = new Vector3(-4f, 1f, 100f);
                Meresankh.position = new Vector3(-5f, 1f, 98);
                MainCamera.enabled = false;
                BattleCamera.enabled = true;
            }
        }
    }
}

    