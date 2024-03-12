using SOS.AndrewsAdventure.Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ahmose : MonoBehaviour
{
    public float maxHP = 9f;
    public float HP = 9;
    public float AM = 1.1f;
    public float BA = 0f;
    public float DD = 0.8f;
    public float BD = 0f;
    private float levelUpConstant = 1.02329299228f;
    public Character level;

    void levelUp(float maxHP, float HP, float AM, float BA, float DD, float BD, int level)
    {
        maxHP = Mathf.Round((maxHP * Mathf.Pow(levelUpConstant, (level - 1 / 2))));
        HP = maxHP;
        AM += 0.03f;
        BA += 0.1f;
        DD += 0.01f;
        BD += 0.5f;
    }
}
