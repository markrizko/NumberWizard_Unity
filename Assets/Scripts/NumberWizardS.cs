using UnityEngine;
using System.Collections;

public class NumberWizardS : MonoBehaviour {

	// Use this for initialization
	void Start () {
	print ("Welcome to my Number Wizard Game!\n Pick a number in your head, but don't tell me!");

	int max = 1000;
	int min = 1;

	print ("The highest number you can pick is " + max + " and the lowest number you can pick is " + min + ".");
	print ("Is the number higher or lower than 500?\nUp arrow = higher, down arrow = lower, and return = equal.");



	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up Arrow pressed.");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down Arrow pressed.");
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
		}
	}
}