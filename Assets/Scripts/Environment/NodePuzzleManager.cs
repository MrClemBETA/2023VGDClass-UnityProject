using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class TouchObjectManager : MonoBehaviour
{
    [SerializeField] int nodesTouched;
    [SerializeField] int nodesNeeded = 4;
    [SerializeField] GameObject disappearingObject;
    private void Start()
    {
        nodesTouched = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(child.gameComponent)
            nodesTouched++;
    }
    void Update()
    {
        if (nodesTouched == nodesNeeded)
        {
            disappearingObject.SetActive(false);
            print("hi");
        }

    }
}
