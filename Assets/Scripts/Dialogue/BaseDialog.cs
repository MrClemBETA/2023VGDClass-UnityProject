using cherrydev;
using UnityEngine;

namespace SOS.AndrewsAdventure.Dialog
{
    public class BaseDialog : MonoBehaviour
    {
        [SerializeField] private DialogBehaviour dialogBehaviour;
        [SerializeField] private DialogNodeGraph dialogNodeGraph;

        void Start()
        {
            dialogBehaviour.StartDialog(dialogNodeGraph);
        }
    }
}
