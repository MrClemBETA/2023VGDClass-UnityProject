using UnityEngine;

namespace SOS.AndrewsAdventure.Dialog
{
    public class NPCDialog : BaseDialog
    {
        public bool CanInteract { get; set; }

        void Start()
        {
            CanInteract = false;
        }

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.E) && CanInteract)
            {
                StartDialog();
            }
        }
    }
}
