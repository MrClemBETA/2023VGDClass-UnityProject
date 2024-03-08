using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    [RequireComponent (typeof(Health))]
    public class Character : MonoBehaviour
    {
        [SerializeField] float attackMultiplier;


        public void TakeDamage(Character enemy)
        {

        }
    }
}
