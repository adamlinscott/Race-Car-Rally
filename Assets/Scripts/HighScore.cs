using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class HighScore : MonoBehaviour 
{
	public string highScoreName;
	public string lastLevelHighScoreName;
	public int minScore;

	// Update is called once per frame
	void Awake() 
    {
		if(PlayerPrefs.GetInt(lastLevelHighScoreName) >= minScore)
		{ 
			GetComponent<Text>().text = "High Score: " + PlayerPrefs.GetInt(highScoreName) + "m"; //text on gui will display highscore stored in player pref
		}
		else
		{
			GetComponent<Text>().text = "Get " + minScore + "m on the last level to unlock!"; //text on gui will display highscore stored in player pref
		}
	} //end OnGUI
} //end class
