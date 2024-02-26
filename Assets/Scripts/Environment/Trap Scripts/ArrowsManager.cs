using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsManager : MonoBehaviour
{
    [SerializeField] float flightTime = 1f;
    [SerializeField] float flightSpeed = 5f;

    private float timer = 0f;
    private Vector3 spawnPosition;
    // Update is called once per frame
    private void Start()
    {
        spawnPosition = transform.position;
        GetComponent<Rigidbody>().velocity = flightSpeed * Vector3.right;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= flightTime)
        {
            transform.position = spawnPosition;
            timer = 0f;
        }
    }

}