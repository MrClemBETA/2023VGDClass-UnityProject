using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lateef : MonoBehaviour
{
    public float maxHP = 15f;
    public float HP = 15;
    public float AM = 0.7f;
    public float BA = 0f;
    public float DD = 1.2f;
    public float BD = 3f;

    void levelUp(float maxHP, float HP, float AM, float BA, float DD, float BD) 
    {
        maxHP *= 1.2f;
        Mathf.Round(maxHP);
        HP = maxHP;
        AM += 0.01f;
        BA += 0.1f;
        DD += 0.01f;
        BD += 0.5f;
    }
}
