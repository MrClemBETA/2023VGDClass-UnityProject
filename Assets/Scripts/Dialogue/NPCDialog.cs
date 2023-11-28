using SOS.AndrewsAdventure.Character;
using UnityEngine;

namespace SOS.AndrewsAdventure.Dialog
{
    public class NPCDialog : BaseDialog
    {
        public bool CanInteract { get; set; }
        public bool DialogHasStarted { get; private set; }

        void Start()
        {
            CanInteract = false;
            DialogHasStarted = false;
        }

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.E) && CanInteract && !DialogHasStarted)
            {
                StartDialog();
                DialogHasStarted = true;
                dialogBehaviour.AddListenerToOnDialogFinished(DialogFinished);
                FindObjectOfType<PlayerController>().CanMove = false;
            }
        }

        void DialogFinished()
        {
            DialogHasStarted = false;
            dialogBehaviour.RemoveListenerFromOnDialogFinished(DialogFinished);
            FindObjectOfType<PlayerController>().CanMove = true;
        }
    }
}
