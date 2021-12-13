using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public float speed = 3f;
    public float rotSpeed = 30f;
    public int score = -1;

    public GameObject Car;
    public GameObject Cube;
    public GameObject Cube1;
    public GameObject Cube2;
    public Text word;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        word.text = "score: " + score;
        float c = Input.GetAxis("Vertical") * speed;
        float r = Input.GetAxis("Horizontal") * speed;
        transform.Translate(new Vector3(r, 0, c) * Time.deltaTime);

        if (Car.transform.position.y < -1) {
            Application.LoadLevel("RoadScene");
        }

        if (Car.transform.position.z > Cube.transform.position.z || Car.transform.position.z > Cube1.transform.position.z || Car.transform.position.z > Cube2.transform.position.z) {
            score = score + 1;
            Debug.Log(score);
        }

    }

    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.name == "Cube" || collision.gameObject.name == "Cube1" || collision.gameObject.name == "Cube2") {
            Application.LoadLevel("RoadScene");
        }
    }
}
