using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	int guessCount;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		guess = 500;
		guessCount = 1;
		max = max + 1; //Gets rid of rounding problem
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me");
		
		
		print ("The HIGHEST number you can pick is " + max);
		print ("The LOWEST number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = arrow for higher, down = for lower, return = for equal");
	}

	void nextGuess() {
		guess = (max + min) / 2;
		print ("Is the number higher or lower than " + guess + "?");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print ("Up arrow pressed");
			guessCount += 1;
			min = guess;
			nextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print ("Down arrow pressed");
			guessCount += 1;
			max = guess;
			nextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			//print ("Return key pressed");
			print ("I got your number in " + guessCount + " questions!");
			StartGame();
		}
	}
}
