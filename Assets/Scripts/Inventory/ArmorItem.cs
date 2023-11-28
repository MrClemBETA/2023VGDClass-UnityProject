using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOS.AndrewsAdventure.Inventory
{
    public enum ArmorType { Head, Torso, Legs, Feet, Hands, Arms}

    public class ArmorItem : BaseItem
    {
        [SerializeField] int baseDefense;
        [SerializeField] ArmorType armorType;
    }
}