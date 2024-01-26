using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateManager : MonoBehaviour
{
    Transform pressurePlate;
    private void Start()
    {
        pressurePlate = GetComponent<Transform>();
    }
    private void OnTriggerEnter(Collider TheOriginalAndrew)
    {
        foreach (Transform child in transform)
        {
            if(child.gameObject.activeSelf == true)
            { //This checks if the spikes are active and deactivates them if they are
                child.gameObject.SetActive(false);
                transform.GetComponent<BoxCollider>().isTrigger = false;
            }
            else if(child.gameObject.activeSelf == false)
            { //This checks if the spikes are inactive and activates them if they are
                child.gameObject.SetActive(true);
                transform.GetComponent<BoxCollider>().isTrigger = false;
            }
        }
        if (transform.name == "SWITCH Pressure Plate" || transform.name == "HOLD Pressure Plate")
        {
            transform.GetComponent<BoxCollider>().isTrigger = true;
        }
    }
    private void OnTriggerExit(Collider TheOriginalAndrew)
    {
        if (transform.name == "HOLD Pressure Plate")
        {
            foreach (Transform child in transform)
            {
                if (child.gameObject.activeSelf == true)
                { //This checks if the spikes are active and deactivates them if they are
                    child.gameObject.SetActive(false);
                }
                else if (child.gameObject.activeSelf == false)
                { //This checks if the spikes are inactive and activates them if they are
                    child.gameObject.SetActive(true);
                }
            }
        }  
    }
}