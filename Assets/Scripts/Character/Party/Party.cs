using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOS.AndrewsAdventure.Character.Party
{
    public class Party : MonoBehaviour
    {
        [SerializeField] PartyData partyData;
        [SerializeField] Transform[] partyFollowPoints;

        void Start()
        {
            int i = 0;
            foreach(var character in partyData.partyMembers)
            {
                if (i >= partyFollowPoints.Length) return;
                GameObject go = Instantiate(character);
                go.GetComponent<PartyFollow>().SetTarget(partyFollowPoints[i++].transform);
            }
        }
    }
}
