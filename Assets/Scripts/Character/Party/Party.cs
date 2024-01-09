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

        private Transform player;
        private GameObject[] partyMembers;

        void Start()
        {
            player = FindAnyObjectByType<PlayerController>().transform;

            int i = 0;
            partyMembers = new GameObject[partyData.partyMembers.Length];
            foreach(var character in partyData.partyMembers)
            {
                if (i >= partyFollowPoints.Length) return;
                GameObject go = Instantiate(character);
                go.transform.position = partyFollowPoints[i].transform.position;
                go.AddComponent<NavMeshAgent>();
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
                go.transform.position = partyFollowPoints[i].position;
                i++;
            }
        }

        public GameObject GetCharacter(string name)
        {
            return partyData.partyMembers.Single(p => p.name == name);
        }
    }
}
