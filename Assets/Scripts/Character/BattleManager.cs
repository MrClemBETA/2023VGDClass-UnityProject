using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

namespace SOS.AndrewsAdventure.Character
{
    
    /// AM = Attack Multiplier, the amount of damage a character's attack is mutiplied by
    /// BA = Bonus Attack, additional damage that isn't affected by the damage calculation
    /// DD = Defense Divider, the value an attack's total damage is divided by
    /// BD = Bonus Defense, additional defense that isn't affected by the defense divider
    [RequireComponent(typeof(Health))]
    public class BattleCharacter : MonoBehaviour
    {
        [SerializeField] public bool inbattle = false;
        public Transform TheOriginalAndrew;
        public Transform TheOriginalLateef;
        public Transform TheOriginalMeresankh;

        public void Start()
        {
            
        }


        public void Update() 
        {

            if (inbattle == true)
            {
                TheOriginalAndrew.transform.position = new Vector3(-3f, 2.31f, 102f);
                TheOriginalLateef.transform.position =  new Vector3(-4f, 1.1f, 100f);
                TheOriginalMeresankh.transform.position = new Vector3(-5f, 2f, 98f);
            }
        }
    }
}

