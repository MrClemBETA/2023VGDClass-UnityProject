using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class TouchObjectManager : MonoBehaviour
{
    int nodesTouched;
    [SerializeField] int nodesNeeded = 3;
    [SerializeField] GameObject disappearingObject;
    private void OnTriggerEnter(Collider other)
    {
        if(other != disappearingObject)
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
