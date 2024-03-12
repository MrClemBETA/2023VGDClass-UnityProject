using Unity.VisualScripting;
using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    [RequireComponent (typeof(Health))]
    public class Character : MonoBehaviour
    {
        public int level = 0;
        [SerializeField] float attackMultiplier;
        [SerializeField] float bonusAttack;
        [SerializeField] float defenseDivider;
        [SerializeField] float bonusDefense;
        [SerializeField] float baseDamage;
        float takenDamage = 0;

        void levelUp()
        {
            level++;
        }

        public void TakeDamage(Character enemy)
        {
            takenDamage = (((baseDamage * attackMultiplier) + bonusAttack)/enemy.defenseDivider) - enemy.bonusDefense;
            Mathf.Round(takenDamage);
            if(takenDamage <= 0)
            {
                takenDamage = 1;
            }
        }
    }
}
