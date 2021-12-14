using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Car;

    int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Car.transform.position.z > Cube.transform.position.z) {
            float min = 1.5f;
            float max = -1.5f;
            float randomx = Random.Range(min, max);
            min = 5 + i;
            max = 5 + i + 5;
            float randomz = Random.Range(min, max);
            Cube.transform.position = new Vector3(randomx, 0.5f, (randomz + 5));
            i = i + 5;
        }
    }
}
