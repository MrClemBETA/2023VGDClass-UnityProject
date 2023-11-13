using Unity.VisualScripting;
using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    public class Health : MonoBehaviour
    {
        [Min(10)]
        [SerializeField] public int maxHealth = 10;
        [SerializeField] int health;
        [SerializeField] int maxiframes = 100;
        private int iframes = 0;
        

        void Start()
        {
            health = maxHealth;
        }

        public void Heal(int health)
        {
            this.health = Mathf.Min(maxHealth, this.health + health);
        }

        public void TakeDamage(int trapDamage)
        {
            int maxiframes = 100;
            print(iframes);
            print("Health: " + health);
            if (iframes == 0)
            {
                this.health = Mathf.Max(0, this.health - trapDamage);
                iframes = maxiframes * OverworldDamage.numberOfTrapsTouched;
            }
            else
            {
                iframes -= 1;
            }
            
        }
    }
}
