﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector;

    Vector3 startingPos;

    //todo remove from inspector later.
    [Range(0,1)][SerializeField] float movementFactor; // 0 to 1, 1 is full movement.

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPos + offset;
    }
}
