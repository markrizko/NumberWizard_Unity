using UnityEngine;
using System.Collections;

public class NumberWizardS : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void NextGuess ()
	{
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("Up arrow = higher, down arrow = lower, and return = equal.");
	}

	void StartGame ()
	{
		max = 1000;
		min = 1;
		guess = 500;
		print ("========================================"); 
		print ("Welcome to my Number Wizard Game!\n Pick a number in your head, but don't tell me!");
		print ("The highest number you can pick is " + max + " and the lowest number you can pick is " + min + ".");
		print ("Is your number larger or smaller than " + guess + "?");
		print ("Up arrow = higher, down arrow = lower, and return = equal.");
		max = max + 1;
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			// print("Up arrow pressed");
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			// print ("Down Arrow pressed.");
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame();
		}
	}
}