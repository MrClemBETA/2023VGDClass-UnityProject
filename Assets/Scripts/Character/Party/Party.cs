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
        [SerializeField] Vector3[] battlePointOffsets;
        [SerializeField] int level = 1;

        private Transform player;
        private GameObject[] partyMembers;

        void Start()
        {
            player = FindAnyObjectByType<CharacterController>().transform;  

            if (battlePointOffsets.Length != partyData.partyMembers.Length)
                throw new UnityException("The number of battle point offsets do not match the number of party members.");

            int i = 0;
            partyMembers = new GameObject[partyData.partyMembers.Length];
            foreach(var character in partyData.partyMembers)
            {
                if (i >= partyFollowPoints.Length) return;
                GameObject go = Instantiate(character);
                go.transform.position = partyFollowPoints[i].transform.position;
                go.GetComponent<NavMeshAgent>().speed = character.GetComponent<PartyFollow>().GetSpeed();
                go.GetComponent<PartyFollow>().SetTarget(partyFollowPoints[i].transform);
                partyMembers[i] = go;
                i++;
            }
        }

        public void MoveParty(Vector3 location)
        {
            player.position = location;
            int i = 0;
            foreach(GameObject go in partyMembers)
            {
                if (i >= partyFollowPoints.Length) return;
                go.transform.position = location + battlePointOffsets[i];
                i++;
            }
        }

        public GameObject GetCharacter(string name)
        {
            return partyData.partyMembers.Single(p => p.name == name);
        }

        public int GetLevel() { return level; }
    }
}
