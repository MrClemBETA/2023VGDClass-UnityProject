using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using SOS.AndrewsAdventure.Character;

namespace SOS.AndrewsAdventure.Battling
{
    public class Battle : MonoBehaviour
    {
        [SerializeField] Transform battleFocusPoint;
        [SerializeField] Transform enemyLocation;
        CinemachineVirtualCamera battleCamera;
        // Start is called before the first frame update
        void Start()
        {
            battleCamera = GetComponentInChildren<CinemachineVirtualCamera>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void StartBattle()
        {
            PlayerController player = FindObjectOfType<PlayerController>();
            Vector3 cameraRotation = Vector3.Cross((player.transform.position - battleFocusPoint.position), Vector3.up);
            battleFocusPoint.position = (enemyLocation.position + player.transform.position) / 2;
            battleFocusPoint.rotation = Quaternion.Euler(cameraRotation);
            battleCamera.Priority = 10;
            player.EnterBattleSequence();
        }
    }
}
