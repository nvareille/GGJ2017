﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlimentDestroyer : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D c)
    {
        Debug.Log(c.name);
    }
}
