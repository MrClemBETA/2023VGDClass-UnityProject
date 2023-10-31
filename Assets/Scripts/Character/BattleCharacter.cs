using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    [RequireComponent(typeof(Health))]
    public class BattleCharacter : Character
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
