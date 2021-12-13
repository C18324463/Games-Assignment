using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 3f;
    public float rotSpeed = 30f;

    public GameObject Car;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float c = Input.GetAxis("Vertical") * speed;
        float r = Input.GetAxis("Horizontal") * speed;
        transform.Translate(new Vector3(r, 0, c) * Time.deltaTime);

        if (Car.transform.position.y < -1) {
            Application.LoadLevel("RoadScene");
        }
    }

    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.name == "Cube" || collision.gameObject.name == "Cube (1)" || collision.gameObject.name == "Cube (2)") {
            Application.LoadLevel("RoadScene");
        }
    }
}
