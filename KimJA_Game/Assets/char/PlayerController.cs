using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed = 8.0f;
    public GameObject arrowPrefab;
    int weapon = 0;

    float span = 0.2f;
    float delta = 0;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;
        Vector3 pos = transform.position;

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {

            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            if (weapon == 0)
            {
                go.transform.position = new Vector3(pos.x, pos.y+1, 0);
            }
            if (weapon == 1)
            {
                GameObject go1 = Instantiate(arrowPrefab) as GameObject;
                GameObject go2 = Instantiate(arrowPrefab) as GameObject;
                go.transform.position = new Vector3(pos.x, pos.y + 1, 0);
                go1.transform.position = new Vector3(pos.x - 1, pos.y + 1, 0);
                go2.transform.position = new Vector3(pos.x + 1, pos.y + 1, 0);
            }
        }
    }
    public void weaponUgrade()
    {
        weapon = 1;
    }
}
