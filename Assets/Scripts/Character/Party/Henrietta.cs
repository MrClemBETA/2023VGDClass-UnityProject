using SOS.AndrewsAdventure.Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Henrietta : MonoBehaviour
{
    public float maxHP = 8f;
    public float HP = 8;
    public float AM = 1.5f;
    public float BA = 5f;
    public float DD = 0.5f;
    public float BD = 0f;
    private float levelUpConstant = 1.02329299228f;
    public Character level;

    void levelUp(float maxHP, float HP, float AM, float BA, float DD, float BD, int level)
    {
        maxHP = Mathf.Round((maxHP * Mathf.Pow(levelUpConstant, (level - 1 / 2))));
        HP = maxHP;
        AM += 0.05f;
        BA += 0.2f;
        DD += 0.01f;
        BD += 0.1f;
    }
}
