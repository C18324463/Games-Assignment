using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerator : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject car;

    int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(myPrefab, new Vector3(3, 0.5f, 8f), Quaternion.identity);
        /*Instantiate(myPrefab, new Vector3(-2, 0.5f, 10f), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(2.5f, 0.5f, 12f), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-2, 0.5f, 14f), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(1, 0.5f, 16f), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(0, 0.5f, 18f), Quaternion.identity);*/
    }

    // Update is called once per frame
    private void Update()
    {
        if (car.transform.position.z > myPrefab.transform.position.z) {
            float min = 1f;
            float max = -1f;
            float randx = Random.Range(min, max);
            min = 5 + i;
            max = 5 + i + 5;
            float randz = Random.Range(min, max);
            myPrefab.transform.position = new Vector3(randx, 1, (randz + 5));
            //Instantiate(myPrefab, new Vector3(randx, 0.5f, randz), Quaternion.identity);
            //Delete();
            i++;
        }
        
    }

    private void Delete() {
        Destroy(myPrefab);
    }
}
