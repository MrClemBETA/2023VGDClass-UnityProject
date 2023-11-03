using cherrydev;
using UnityEngine;

public class TestDialogue : MonoBehaviour
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogNodeGraph;

    void Start()
    {
        dialogBehaviour.StartDialog(dialogNodeGraph);
    }
}
