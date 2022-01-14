using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMoving : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(this.gameObject);
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 25f * Time.deltaTime, 0);

        if (transform.position.y > 9.0f)
        {
            Destroy(gameObject);
        }
    }
}
