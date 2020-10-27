﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCubeBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 RotateAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount * Time.deltaTime);
    }
}
