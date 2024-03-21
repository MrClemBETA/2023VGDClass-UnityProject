using System;
using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    [CreateAssetMenu(fileName = "attribute", menuName = "Andrew's Adventure/Attributes/New Attribute", order = 1)]
    [Serializable]
    public class Attribute : ScriptableObject
    {
        [SerializeField] float startingValue;
        [SerializeField] float incrementalValue;

        public int GetData(int level)
        {
            return (int)Math.Floor(startingValue + level * incrementalValue);
        }

    }
}
