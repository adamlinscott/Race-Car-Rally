using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
	//variables
	public static int score;
	public int timeAdjust = 1;
	int timer;

	Text text;

	void Awake()
	{
		text = GetComponent<Text>();
		score = 0;
		timer = timeAdjust;
	} //end Start

	// Update is called once per frame
	void Update()
    {
		if (timer <= 0 && CarScript.isInGame == true) 
		{
			score++; //increase score

			text.text = "Distance: " + score + "m"; //update GUI
			
			timer = timeAdjust;
		} //end if
		
		timer--; //countdown to score update 
	}
} //end class
