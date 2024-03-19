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

        private void OnMouseDown()
        {
            /*if(inBattle == true)
            {
                if (transform.name == "Lateef")
                {
                    get
                }
            } Don't know what's going on here, let's make sure this is cleaned up */
        }
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
            int AM = GetData("AM");
            int DD = enemy.GetData("DD");
            int BD = enemy.GetData("BD");
            int BA = GetData("BA");

            takenDamage = ((baseDamage * AM)/DD) - BD + BA;
            Mathf.Round(takenDamage);
            if(takenDamage <= 0)
            {
                takenDamage = 1;
            }
        }
    }
}
