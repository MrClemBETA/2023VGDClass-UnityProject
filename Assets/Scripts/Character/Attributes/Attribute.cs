using System;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEditor.UI;
using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    public abstract class Attribute : ScriptableObject
    {
        [SerializeField] List<AttributeByLevel> values;

        public int GetData(int level)
        {
            int value = values.Find(x => x.level == level).value;
            if (value == 0)
                throw new IndexOutOfRangeException("Level data for level " + level + " does not exist for the " + this.GetType().Name + ".");
            else
                return value;

        }

        [Serializable]
        public struct AttributeByLevel
        {
            [Range(1, 100)]
            public int level;
            [Range(1, 100)]
            public int value;
        }
    }
}
