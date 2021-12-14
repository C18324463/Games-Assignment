using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    public float speed = 3f;
    public float rotSpeed = 30f;
    public int score = -1;
    public int highscore = 0;
    public int lastscore = 0;
    string highScoreKey = "HighScore";
    string lastScoreKey = "LastScore";

    public GameObject Car;
    public GameObject Cube;
    public GameObject Cube1;
    public GameObject Cube2;
    public Text current;
    public Text high;
    public Text last;
    public AudioSource crash;
    public AudioSource scream;


    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt(highScoreKey, 0);
        lastscore = PlayerPrefs.GetInt(lastScoreKey, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        current.text = "CURRENT SCORE: " + score;
        high.text = "HIGHSCORE: " + highscore;
        last.text = "LAST SCORE: " + lastscore;
        float vert = Input.GetAxis("Vertical") * speed;
        float horiz = Input.GetAxis("Horizontal") * speed;
        transform.Translate(new Vector3(horiz, 0, vert) * Time.deltaTime);

        if (Car.transform.position.y < -1) {
            if (highscore < score) {
                PlayerPrefs.SetInt(highScoreKey, score);
                PlayerPrefs.SetInt(lastScoreKey, score);
                PlayerPrefs.Save();
            } else if (score < highscore) {
                PlayerPrefs.SetInt(lastScoreKey, score);
                PlayerPrefs.Save();
            }
            SceneManager.LoadScene("RoadScene");
        }

        if (Car.transform.position.z > Cube.transform.position.z || Car.transform.position.z > Cube1.transform.position.z || Car.transform.position.z > Cube2.transform.position.z) {
            score = score + 1;
            if ((score % 10) == 0) {
                speed = speed + 0.5f;
            }
            if (highscore < score) {
                PlayerPrefs.SetInt(highScoreKey, score);
                PlayerPrefs.SetInt(lastScoreKey, score);
                PlayerPrefs.Save();
            } else if (score < highscore) {
                PlayerPrefs.SetInt(lastScoreKey, score);
                PlayerPrefs.Save();
            }
        }
    }

    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.name == "Cube" || collision.gameObject.name == "Cube1" || collision.gameObject.name == "Cube2") {
            crash.Play();
            StartCoroutine(Fade());
        }
    }

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(0.5f);
        if (highscore < score) {
                PlayerPrefs.SetInt(highScoreKey, score);
                PlayerPrefs.SetInt(lastScoreKey, score);
                PlayerPrefs.Save();
            } else if (score < highscore) {
                PlayerPrefs.SetInt(lastScoreKey, score);
                PlayerPrefs.Save();
            }
            SceneManager.LoadScene("RoadScene");
    }
}
