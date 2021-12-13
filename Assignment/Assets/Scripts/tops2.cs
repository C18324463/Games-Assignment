using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tops2 : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Car;

    int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Cube, new Vector3(3, 0.5f, 8f), Quaternion.identity);
        /*Instantiate(Cube, new Vector3(-2, 0.5f, 10f), Quaternion.identity);
        Instantiate(Cube, new Vector3(2.5f, 0.5f, 12f), Quaternion.identity);
        Instantiate(Cube, new Vector3(-2, 0.5f, 14f), Quaternion.identity);
        Instantiate(Cube, new Vector3(1, 0.5f, 16f), Quaternion.identity);
        Instantiate(Cube, new Vector3(0, 0.5f, 18f), Quaternion.identity);*/
    }

    // Update is called once per frame
    private void Update()
    {
        if (Car.transform.position.z > Cube.transform.position.z) {
            float min = 3.5f;
            float max = 2.5f;
            float randx = Random.Range(min, max);
            min = 5 + i;
            max = 5 + i + 5;
            float randz = Random.Range(min, max);
            Cube.transform.position = new Vector3(randx, 0.5f, (randz + 5));
            i = i + 5;
        }
    }
}
