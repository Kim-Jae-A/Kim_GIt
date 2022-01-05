using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMoving : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.1f, 0);

        if (transform.position.y > 9.0f)
        {
            Destroy(gameObject);
        }
    }
}
