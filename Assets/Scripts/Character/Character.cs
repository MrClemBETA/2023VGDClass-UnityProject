using SOS.AndrewsAdventure.Character;
using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    [RequireComponent(typeof(Health))]
    public class Character : MonoBehaviour
    {
        [SerializeField] AttackAttribute attackAttribute;
        [SerializeField] DefenseAttribute defenseAttribute;
        [SerializeField] SpeedAttribute speedAttribute;

        void Start()
        {
            print(GetData());
        }

        private string GetData()
        {
            return attackAttribute.GetData(1) + ", " + defenseAttribute.GetData(1) + ", " + speedAttribute.GetData(1);
        }
    }
}
