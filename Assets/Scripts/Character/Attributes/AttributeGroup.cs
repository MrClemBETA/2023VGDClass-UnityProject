using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace SOS.AndrewsAdventure.Character
{
    [CreateAssetMenu(fileName = "attributeGroup", menuName = "Andrew's Adventure/Attributes/New Attribute Group", order = 2)]
    public class AttributeGroup : ScriptableObject
    {
        [SerializeField] List<Attribute> attributes = new List<Attribute>();

        public Attribute GetAttribute(string name)
        {
            try
            {
                return attributes.First(x => x.name == name);
            } catch
            {
                throw new Exception("Invalid attribute " + name + " given to the character.");
            }
        }
    }
}