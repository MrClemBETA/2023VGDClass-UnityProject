using SOS.AndrewsAdventure.Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andrew : MonoBehaviour
{
    public int HP = 10;
    private float levelUpConstant = 1.02329299228f;
    public Character level;
    public Dictionary<string, float> andrewStats = new Dictionary<string,float>();

    private void Start()
    {
        andrewStats.Add("maxHP", 10);
        andrewStats.Add("AM", 1);
        andrewStats.Add("BA", 0);
        andrewStats.Add("DD", 1);
        andrewStats.Add("BD", 0);
    }

    void levelUp(int level)
    {
        andrewStats.maxHP = Mathf.Round((maxHP * Mathf.Pow(levelUpConstant, (level - 1 / 2))));
        andrewStats.Add(HP = maxHP;
        AM += 0.01f;
        BA += 0.1f;
        DD += 0.01f;
        BD += 0.1f;
    }
}
