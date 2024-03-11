using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meresankh : MonoBehaviour
{
    public float maxHP = 12f;
    public float HP = 12;
    public float AM = 0.9f;
    public float BA = 1f;
    public float DD = 0.9f;
    public float BD = 0f;

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
