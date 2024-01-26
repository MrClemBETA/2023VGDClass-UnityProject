using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsManager : MonoBehaviour
{
    [SerializeField] public int flightTime = 60;
    private int timer = 60;
    private Vector3 spawnPosition;
    // Update is called once per frame
    private void Start()
    {
        spawnPosition = transform.position;
    }
    void Update()
    {
        transform.localPosition += new Vector3(0.25f, 0, 0);
        timer -= 1;
        if (timer == 0)
        {
            transform.position = spawnPosition;
            timer = flightTime;

        }
    }

}