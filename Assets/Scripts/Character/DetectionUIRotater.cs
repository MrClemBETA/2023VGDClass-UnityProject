using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionUIRotater : MonoBehaviour
{
    public Transform MCB;

    void Update()
    {
        transform.LookAt(MCB);
    }
}

