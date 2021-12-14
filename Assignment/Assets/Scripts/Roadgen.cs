using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class
public class RoadGen : MonoBehaviour
{
    //Game Object array
    public GameObject[] roadPrefabs;

    //Variables
    public float zSpawn = 0;
    public float roadLength = 5;
    public int numOfRoads = 3;
    
    //Transform
    public Transform playerTransform;

    //List of Game Objects
    private List<GameObject> activeRoad = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //For i less than number of roads(2)
        for(int i=0; i<numOfRoads; i++){
            //Spawns the road
            SpawnRoad(Random.Range(0, roadPrefabs.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        //If the z position of players movement minus 35 is grreater than the zSpawn minus number of roads(2) times the road length(5)
        if(playerTransform.position.z - 35 > zSpawn-(numOfRoads*roadLength)){
            //Spawns more road
            SpawnRoad(Random.Range(0, roadPrefabs.Length));
            //Calls Delete Road function
            DeleteRoad();
        }
    }

    //Spawn Road function
    public void SpawnRoad(int roadIndex){
        //Puts the instantiated road into the a game object
        GameObject gameObj = Instantiate(roadPrefabs[roadIndex], transform.forward * zSpawn, transform.rotation );
        //Adds to the active road
        activeRoad.Add(gameObj);
        //Adds road on to zSpawn
        zSpawn += roadLength;
    }

    //Delete Road function
    private void DeleteRoad(){
        //Destroys the last road
        Destroy(activeRoad[0]);
        activeRoad.RemoveAt(0);
    }
}