using Unity.VisualScripting;
using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    [RequireComponent (typeof(Health))]
    public class Character : MonoBehaviour
    {
        public int level = 0;
        [SerializeField] float AM;
        [SerializeField] float BA;
        [SerializeField] float DD;
        [SerializeField] float BD;
        [SerializeField] float baseDamage;
        float takenDamage = 0;
        public EnemyManager inBattle;

        private void OnMouseDown()
        {
            if(inBattle == true)
            {
                if (transform.name == "Lateef")
                {
                    get
                }
            }
        }
        void levelUp()
        {
            level++;
        }

        public void TakeDamage(chosenCharacter enemy)
        {
            takenDamage = ((baseDamage * AM)/enemy.DD) - enemy.BD + BA;
            Mathf.Round(takenDamage);
            if(takenDamage <= 0)
            {
                takenDamage = 1;
            }
        }
    }
}
