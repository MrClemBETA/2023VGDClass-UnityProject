using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    [RequireComponent (typeof(Health))]
    public class Character : MonoBehaviour
    {
        public int level = 0;
        [SerializeField] AttributeGroup attributes;
        float takenDamage = 0;
        public EnemyManager inBattle;

        void levelUp()
        {
            level++;
        }

        public int GetData(string att)
        {
            return attributes.GetAttribute(att).GetData(level);
        }

        public void TakeDamage(Character enemy)
        {
            int baseDamage = GetData("Base Damage");
            int AM = GetData("Attack Multiplier");
            int BA = GetData("Bonus Attack");
            int DD = enemy.GetData("Defense Divider");
            int BD = enemy.GetData("Bonus Defense");

            takenDamage = ((baseDamage * AM)/DD) - BD + BA;
            Mathf.Round(takenDamage);
            if(takenDamage <= 0)
            {
                takenDamage = 1;
            }
        }
    }
}
