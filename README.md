# Project Title

Name: Gabriel Hynes

Student Number: C18324463

Class Group: TU857/DT211C

# Description of the project

When you start my game, you spawn as a car. The objective of the game is to drive the car forward, past the procedurally generating boxes that spawn in random locations when you pass them. For every box you pass, you get 1 point added to your score. Every 10 points you get, the speed of the car increases so the game gets progressively harder. If you hit a box, audio plays a crashing noise and the game ends and you respawn back at the start and your score resets. It displays the score of your last game in the bottom corner. It also displays the highscore. If you fall off the level, you will also respawn back at the start and again, your score resets and the last score you got will display.

# Instructions for use

You spawn as a car. To drive forward, you use the up arrow key or the w key. To drive left and right, you use the left and right arrow keys as well as the a and d keys. To go backwards, you use the back arrow key or the s key. The aim of the game is to dodge the boxes driving forwards and try beat the highscore.

# How it works

You spawn in as a car. You can move around in all directions, forward, back, left and right. You move up to the start line and when you drive over it, the game begins.

![start image](https://github.com/C18324463/Games-Assignment/blob/main/Start.JPG)

As you drive past the boxes, your score increases.

![score image](https://github.com/C18324463/Games-Assignment/blob/main/Score1.JPG)

When you reach a score of 10, the speed increases.

![score2 image](https://github.com/C18324463/Games-Assignment/blob/main/Score12.JPG)

When you fall off or hit a box, you respawn bakc at the start and your score resets.

![crash image](https://github.com/C18324463/Games-Assignment/blob/main/AfterCrash.JPG)

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

## This is how to markdown text:

This is *emphasis*

This is a bulleted list

- Item
- Item

This is a numbered list

1. Item
1. Item

This is a [hyperlink](http://bryanduggan.org)

# Headings
## Headings
#### Headings
##### Headings

This is code:

```Java
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

So is this without specifying the language:

```
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

This is an image using a relative URL:

![An image](images/p8.png)

This is an image using an absolute URL:

![A different image](https://bryanduggandotorg.files.wordpress.com/2019/02/infinite-forms-00045.png?w=595&h=&zoom=2)

This is a youtube video:

[![YouTube](http://img.youtube.com/vi/J2kHSSFA4NU/0.jpg)](https://www.youtube.com/watch?v=J2kHSSFA4NU)

This is a table:

| Heading 1 | Heading 2 |
|-----------|-----------|
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |

