﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEdit : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("player");
            director.GetComponent<PlayerController>().WeaponUgrade();

            Destroy(gameObject);
        }
    }
}
