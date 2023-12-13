using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOS.AndrewsAdventure.Character.Party
{
    [CreateAssetMenu(fileName = "PartyData", menuName = "Andrew's Adventure/New PartyData", order = 4)]
    public class PartyData : ScriptableObject
    {
        public GameObject[] partyMembers;
    }
}
