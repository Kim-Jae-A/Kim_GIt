using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPack : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
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
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().HealHp();

            Destroy(gameObject);

        }
    }
}
