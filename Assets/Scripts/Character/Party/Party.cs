using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

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
                go.transform.position = partyFollowPoints[i].transform.position;
                go.AddComponent<NavMeshAgent>();
                go.GetComponent<NavMeshAgent>().speed = character.GetComponent<PartyFollow>().GetSpeed();
                go.GetComponent<PartyFollow>().SetTarget(partyFollowPoints[i++].transform);
            }
        }

        public GameObject GetCharacter(string name)
        {
            return partyData.partyMembers.Single(p => p.name == name);
        }
    }
}
