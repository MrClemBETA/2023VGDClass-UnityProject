using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOS.AndrewsAdventure.Inventory
{
    
    public enum ArmorType { Head, Torso, Legs, Feet, Hands, Arms}
    [CreateAssetMenu(fileName = "baseItem", menuName = V, order = 6)]
    public class ArmorItem : BaseItem
    {
        private const string V = "Andrew's Adventure/Inventory Armor";
        [SerializeField] int baseDefense;
        [SerializeField] ArmorType armorType;
    }
}