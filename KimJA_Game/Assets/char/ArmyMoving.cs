using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmyMoving : MonoBehaviour
{
    GameObject player;
    int hp = 2;

    void OnCollisionEnter2D(Collision2D collision)
    {
        hp -= 1;
        if (hp == 0)
        {
            Destroy(this.gameObject);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().PlusScore();

        }
    }

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -10.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            Destroy(gameObject);

        }
    }
}
