using cherrydev;
using UnityEngine;

namespace SOS.AndrewsAdventure.Dialog
{
    public class BaseDialog : MonoBehaviour
    {
        [SerializeField] protected DialogBehaviour dialogBehaviour;
        [SerializeField] private DialogNodeGraph dialogNodeGraph;

        public void StartDialog()
        {
            dialogBehaviour.gameObject.SetActive(true);
            dialogBehaviour.StartDialog(dialogNodeGraph);
        }
    }
}
