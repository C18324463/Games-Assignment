using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Class
public class CarController : MonoBehaviour
{
    //Variables
    public float speed = 3f;
    public float rotSpeed = 30f;
    public int score = -1;
    public int highscore = 0;
    public int lastscore = 0;
    string highScoreKey = "HighScore";
    string lastScoreKey = "LastScore";

    //Game Objects
    public GameObject Car;
    public GameObject Cube;
    public GameObject Cube1;
    public GameObject Cube2;
    //Texts
    public Text current;
    public Text high;
    public Text last;
    //Audio Sources
    public AudioSource crash;
    public AudioSource scream;


    // Start is called before the first frame update
    void Start()
    {
        //Takes high and last scores from last game and displays them on game start
        highscore = PlayerPrefs.GetInt(highScoreKey, 0);
        lastscore = PlayerPrefs.GetInt(lastScoreKey, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        //Displays text and scores on screen
        current.text = "CURRENT SCORE: " + score;
        high.text = "HIGHSCORE: " + highscore;
        last.text = "LAST SCORE: " + lastscore;
        //Puts the axises times the speed into the variables
        float vert = Input.GetAxis("Vertical") * speed;
        float horiz = Input.GetAxis("Horizontal") * speed;
        //Moves vehicle at those speeds on those axis by the time
        transform.Translate(new Vector3(horiz, 0, vert) * Time.deltaTime);

        //If car goes below a certain y axis(falls off)
        if (Car.transform.position.y < -1) {
            //If the highscore is lower than the score
            if (highscore < score) {
                //Puts score into the highscore key
                PlayerPrefs.SetInt(highScoreKey, score);
                //Puts score into the lastscore key
                PlayerPrefs.SetInt(lastScoreKey, score);
                //Saves the keys
                PlayerPrefs.Save();
            //If score is less than highscore
            } else if (score < highscore) {
                //Puts score into the lastscore key
                PlayerPrefs.SetInt(lastScoreKey, score);
                //Saves the keys
                PlayerPrefs.Save();
            }
            //Resets the scene(respawns the vehicle)
            SceneManager.LoadScene("RoadScene");
        }

        //If the cars z position is greater than Cube's, Cube1's or Cube2's z position
        if (Car.transform.position.z > Cube.transform.position.z || Car.transform.position.z > Cube1.transform.position.z || Car.transform.position.z > Cube2.transform.position.z) {
            //Adds 1 to your score
            score = score + 1;
            //If the score divided by 10 equals 0
            if ((score % 10) == 0) {
                //Speed up the vehicle by 0.5 seconds
                speed = speed + 0.5f;
            }
            //If the highscore is lower than the score
            if (highscore < score) {
                //Puts score into the highscore key
                PlayerPrefs.SetInt(highScoreKey, score);
                //Puts score into the lastscore key
                PlayerPrefs.SetInt(lastScoreKey, score);
                //Saves the keys
                PlayerPrefs.Save();
            //If score is less than highscore
            } else if (score < highscore) {
                //Puts score into the lastscore key
                PlayerPrefs.SetInt(lastScoreKey, score);
                //Saves the keys
                PlayerPrefs.Save();
            }
        }
    }

    //Collision 
    void OnCollisionEnter (Collision collision) {
        //If your vehicle collides with any of the Cubes
        if (collision.gameObject.name == "Cube" || collision.gameObject.name == "Cube1" || collision.gameObject.name == "Cube2") {
            //Plays the crash audio
            crash.Play();
            //Calls the coroutine
            StartCoroutine(Noise());
        }
    }

    //IEnumerator
    IEnumerator Noise()
    {
        //Waits 0.5 seconds to allow for sound to play
        yield return new WaitForSeconds(0.5f);
        //If the highscore is lower than the score
        if (highscore < score) {
                //Puts score into the highscore key
                PlayerPrefs.SetInt(highScoreKey, score);
                //Puts score into the lastscore key
                PlayerPrefs.SetInt(lastScoreKey, score);
                //Saves the keys
                PlayerPrefs.Save();
            //If score is less than highscore
            } else if (score < highscore) {
                //Puts score into the lastscore key
                PlayerPrefs.SetInt(lastScoreKey, score);
                //Saves the keys
                PlayerPrefs.Save();
            }
            //Resets the scene(respawns the vehicle)
            SceneManager.LoadScene("RoadScene");
    }
}
