using UnityEngine;

namespace SOS.AndrewsAdventure.Battling
{
    public class BattleTrigger : MonoBehaviour
    {
        [SerializeField] Battle battle;

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                gameObject.SetActive(false);
                battle.StartBattle();
            }
        }
    }
}