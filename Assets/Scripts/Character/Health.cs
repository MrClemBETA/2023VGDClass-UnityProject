using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    public class Health : MonoBehaviour
    {
        [Min(10)]
        [SerializeField] int maxHealth = 100;

        private int health;

        void Start()
        {
            health = maxHealth;
        }

        public void Heal(int health)
        {
            this.health = Mathf.Min(maxHealth, this.health + health);
        }

        public void TakeDamage()
        {
            this.health = Mathf.Max(0, this.health - health);
        }
    }
}
