using SOS.AndrewsAdventure.Dialog;
using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    [RequireComponent(typeof(NPCDialog))]
    public class NPC : Character
    {

        private NPCDialog npcDialog;

        void Start()
        {
            npcDialog = GetComponent<NPCDialog>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                StartDialog();
            }
        }

        public void StartDialog()
        {
            npcDialog.StartDialog();
        }
    }
}
