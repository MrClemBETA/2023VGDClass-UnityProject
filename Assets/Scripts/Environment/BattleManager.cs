using SOS.AndrewsAdventure.Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public enum BattleState { start, playerTurn, enemyTurn, won, lost }
public class NewBehaviourScript : MonoBehaviour
{
    Lateef lateef;
    /// AM = Attack Multiplier, the amount of damage a character's attack is mutiplied by
    /// BA = Bonus Attack, additional damage that isn't affected by the damage calculation
    /// DD = Defense Divider, the value an attack's total damage is divided by
    /// BD = Bonus Defense, additional defense that isn't affected by the defense divider
    [SerializeField] EnemyManager inBattle;
    [SerializeField] Health health;
    public Transform chosenCharacter;
    public Transform chosenEnemy;

    void Awake()
    {
        lateef = GameObject.Find()
    }
    void chooseCharacter()
    {
        if (chosenCharacter.name == "Lateef")
        {

        }
    }

    void damageCalculation(float chosenCharacter.AM, float chosenCharacter.BA, float chosenEnemy.DD, float chosenCharacter.BD) 
    { 
    
    }

    private void Start()
    {

    }

    private void Update()
    {
        if (inBattle == true)
        {

            if (health.health > 0)
            {

            }
        }
    }
}
