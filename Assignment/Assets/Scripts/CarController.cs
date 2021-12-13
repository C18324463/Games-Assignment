using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public float speed = 3f;
    public float rotSpeed = 30f;
    public int score = -1;
    public int highscore = 0;

    public GameObject Car;
    public GameObject Cube;
    public GameObject Cube1;
    public GameObject Cube2;
    public Text word1;
    public Text word2;


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("High Score");
    }

    // Update is called once per frame
    void Update()
    {
        word1.text = "SCORE:" + score;
        word2.text = "HIGHSCORE:" + highscore;
        float v = Input.GetAxis("Vertical") * speed;
        float h = Input.GetAxis("Horizontal") * speed;
        transform.Translate(new Vector3(h, 0, v) * Time.deltaTime);

        if (Car.transform.position.y < -1) {
            Application.LoadLevel("RoadScene");
            PlayerPrefs.SetInt("High Score", highscore);
        }

        if (Car.transform.position.z > Cube.transform.position.z || Car.transform.position.z > Cube1.transform.position.z || Car.transform.position.z > Cube2.transform.position.z) {
            score = score + 1;
            Debug.Log(score);
            if (highscore < score) {
                highscore = score;
                Debug.Log(highscore + "top");
            }
        }

    }

    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.name == "Cube" || collision.gameObject.name == "Cube1" || collision.gameObject.name == "Cube2") {
            highscore = score;
            Application.LoadLevel("RoadScene");
            //highscore = score;
        }
    }
}
