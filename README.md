# Project Title

Box Dodgers

Name: Gabriel Hynes

Student Number: C18324463

Class Group: TU857/DT211C

# Description of the project

When you start my game, you spawn as a car. The objective of the game is to drive the car forward, past the procedurally generating boxes that spawn in random locations when you pass them. For every box you pass, you get 1 point added to your score. Every 10 points you get, the speed of the car increases so the game gets progressively harder. If you hit a box, audio plays a crashing noise and the game ends and you respawn back at the start and your score resets. It displays the score of your last game in the bottom corner. It also displays the highscore. If you fall off the level, you will also respawn back at the start and again, your score resets and the last score you got will display.

# Instructions for use

You spawn as a car. To drive forward, you use the up arrow key or the w key. To drive left and right, you use the left and right arrow keys as well as the a and d keys. To go backwards, you use the back arrow key or the s key. The aim of the game is to dodge the boxes driving forwards and try beat the highscore.

# How it works

You spawn in as a car. You can move around in all directions, forward, back, left and right. You move up to the start line and when you drive over it, the game begins.


```C#
private void Update()
    {
        //If cars z position is greater than cubes z position
        if (Car.transform.position.z > Cube.transform.position.z) {
            //Set the max and min for the cubes spawning location
            float min = 1.5f;
            float max = -1.5f;
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
```

As you drive past the boxes, your score increases.

![score image](https://github.com/C18324463/Games-Assignment/blob/main/Score1.JPG)

When you reach a score of 10, the speed increases.

![score2 image](https://github.com/C18324463/Games-Assignment/blob/main/Score12.JPG)

```C#
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
```

When you fall off or hit a box, you respawn bakc at the start and your score resets.

![crash image](https://github.com/C18324463/Games-Assignment/blob/main/AfterCrash.JPG)

```C#
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

void OnCollisionEnter (Collision collision) {
//If your vehicle collides with any of the Cubes
	if (collision.gameObject.name == "Cube" || collision.gameObject.name == "Cube1" || collision.gameObject.name == "Cube2") {
 	   //Plays the crash audio
 	   crash.Play();
 	   //Calls the coroutine
 	   StartCoroutine(Noise());
	}
}
```

When you crash into a box, it makes a noise of crashing

```C#
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
```

[![YouTube](https://github.com/C18324463/Games-Assignment/blob/main/Start.JPG)](https://www.youtube.com/watch?v=HE6J5yPjY2U)


# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

| Class/asset | Source |
|-----------|-----------|
| CarController.cs | Modified from [https://answers.unity.com/questions/672869/player-prefs-to-store-high-scores.html]() and Bryan Duggan|
| CubeScript.cs | Self written |
| CubeScript1.cs | Self written |
| CubeScript2.cs | Self written |
| RoadGen.cs | Modified from [https://answers.unity.com/questions/1818562/how-to-instantiate-road-prefab-at-desired-position-1.html]() |
| FS000_Night_01.png | [https://assetstore.unity.com/packages/2d/textures-materials/sky/fantasy-skybox-free-18353]() |
| Cube.prefab | Self written |
| CarCrash.wav | [https://www.mediafire.com/file/cd9k5trccmyt9e0/car_crash_SoundEffectsFactory.wav/file]() |

# References
[https://answers.unity.com/questions/672869/player-prefs-to-store-high-scores.html]()

[https://answers.unity.com/questions/1818562/how-to-instantiate-road-prefab-at-desired-position-1.html]()

[https://assetstore.unity.com/packages/2d/textures-materials/sky/fantasy-skybox-free-18353]()

[https://www.mediafire.com/file/cd9k5trccmyt9e0/car_crash_SoundEffectsFactory.wav/file]()

Bryan Duggan

# What I am most proud of in the assignment

I am most proud about my assignment that it actually fully works the way I thought it would work liek from the start. There was a point at the start of the assignment that I didn't actually doing this project would actually be fully completed up to the standard I actually did reach. I am proud that I got the score board working and that it shows the current score, the score you got in the last game and the highscore.

# Proposal submitted earlier can go here:

Games Engines 1 Assignment

The project I would like to do would be to build a prodecurally genertaed road with obstacles and you are controlling a car and are trying to avoid the obstacles.

