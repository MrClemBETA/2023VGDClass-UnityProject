using SOS.AndrewsAdventure.Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldDamage : MonoBehaviour
{
    [SerializeField] int trapDamage = 1;
    public static int numberOfTrapsTouched = 0;

    
    private void OnTriggerStay(Collider other)
    {
        Health playerHealth = FindAnyObjectByType<PlayerController>().gameObject.GetComponent<Health>();
        playerHealth.TakeDamage(trapDamage);
    }
    public void OnTriggerEnter(Collider other)
    {
        numberOfTrapsTouched += 1;
    }
    public void OnTriggerExit(Collider other)
    {
        numberOfTrapsTouched -= 1;  
    }

}
