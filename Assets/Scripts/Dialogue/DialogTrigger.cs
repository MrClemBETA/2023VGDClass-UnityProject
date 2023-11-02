using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOS.AndrewsAdventure.Dialog
{
    public class DialogTrigger : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                GetComponentInParent<NPCDialog>().CanInteract = true;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if(other.tag == "Player")
            {
                GetComponentInParent<NPCDialog>().CanInteract = false;
            }
        }
    }

}