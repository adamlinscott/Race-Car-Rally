using System;
using System.IO;
using UnityEngine;
using System.Collections;


public class ResetScript : MonoBehaviour 
{
	public GameObject panel;
	public string highScoreName;
	public string lastScoreName;
	public GameObject car;


	void OnCollisionEnter2D(Collision2D collision)
	{
		if (ScoreScript.score > PlayerPrefs.GetInt(highScoreName)) //was high score beaten?
		{
			PlayerPrefs.SetInt(highScoreName, ScoreScript.score); //replace highscore
		} //end if

		PlayerPrefs.SetInt(lastScoreName, ScoreScript.score); //set last highscore

		CarScript.isInGame = false; //back to MainMenu scene
		Time.timeScale = 0;

		panel.SetActive(true);

		car.SetActive(false);
	} //end OnCollisionEnter
} //end class
