using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class
public class Cube1Script : MonoBehaviour
{
    //Game Objects
    public GameObject Cube;
    public GameObject Car;
    
    //Variables
    int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //If cars z position is greater than cubes z position
        if (Car.transform.position.z > Cube.transform.position.z) {
            //Set the max and min for the cubes spawning location
            float min = -2.5f;
            float max = -3.5f;
            //Puts them into a random x variable
            float randomx = Random.Range(min, max);
            //Adds 5 and i to the min and max to keep to moving
            min = 5 + i;
            max = 5 + i + 5;
            //Puts them into a random z variable
            float randomz = Random.Range(min, max);
            //Cubes position randomly spawns within the area
            Cube.transform.position = new Vector3(randomx, 0.5f, (randomz + 5));
            //Adds 5 to i
            i = i + 5;
        }
    }
}
