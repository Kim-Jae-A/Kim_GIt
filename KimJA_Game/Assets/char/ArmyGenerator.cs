using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyGenerator : MonoBehaviour
{
    public GameObject armyPrefab;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(armyPrefab) as GameObject;
            GameObject go1 = Instantiate(armyPrefab) as GameObject;
            GameObject go2 = Instantiate(armyPrefab) as GameObject;
            GameObject go3 = Instantiate(armyPrefab) as GameObject;
            GameObject go4 = Instantiate(armyPrefab) as GameObject;
            go.transform.position = new Vector3(-6, 9, 0);
            go1.transform.position = new Vector3(-3, 9, 0);
            go2.transform.position = new Vector3(0, 9, 0);
            go3.transform.position = new Vector3(3, 9, 0);
            go4.transform.position = new Vector3(6, 9, 0);
        }
    }
}
