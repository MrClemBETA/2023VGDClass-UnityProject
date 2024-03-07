using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lateef : MonoBehaviour
{
    public int maxHP = 15;
    public int HP = 15;
    public float AM = 0.7f;
    public float BA = 0f;
    public float DD = 1.2f;
    public float BD = 3f;

    void levelUp(int maxHP, int HP, float AM, float BA, float DD, float BD) 
    {
        maxHP++;
        HP = maxHP;
        AM += 0.01f;
        BA += 0.1f;
        DD += 0.01f;
        BD += 0.5f;
    }
}
