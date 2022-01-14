using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmyMoving : MonoBehaviour
{
    GameObject player;
    int hp = 2;
    public int dice = 0;

    void OnCollisionEnter2D(Collision2D other)
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
        dice = Random.Range(1, 3);

    }

    // Update is called once per frame
    void Update()
    {
        if (dice == 1)
        {
            transform.Translate(0, -30f * Time.deltaTime, 0);
        }
        else if (dice == 2)
        {
            transform.Translate(3f * Time.deltaTime, -30f * Time.deltaTime, 0);

        }
        else
        {
            transform.Translate(-3f * Time.deltaTime, -30f * Time.deltaTime, 0);
        }

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
