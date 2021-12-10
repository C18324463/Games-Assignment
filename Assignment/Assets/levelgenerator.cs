using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerator : MonoBehaviour
{
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, new Vector3(1, 0.5f, 8f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
