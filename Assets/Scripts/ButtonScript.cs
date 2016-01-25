using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour 
{
	//level names
	public string level1High;
	public string level2High;
	public string level3High;

	//button click methods
	public void LoadMain()
	{
		Time.timeScale = 1;
		Application.LoadLevel("MainScene");
	}

	public void LoadLevelSelect()
	{
		Time.timeScale = 1;
		Application.LoadLevel("LevelSelectScene");
	}

	public void RestartLevel()
	{
		Time.timeScale = 1;
		Application.LoadLevel(Application.loadedLevel);
	}

	public void LoadLevel1()
	{
		Application.LoadLevel("Level1Scene");
	}

	public void LoadLevel2()
	{
		if (PlayerPrefs.GetInt(level1High) >= 115)
		{
			Application.LoadLevel("Level2Scene");
		}
	}

	public void LoadLevel3()
	{
		if (PlayerPrefs.GetInt(level2High) >= 225)
		{
			Application.LoadLevel("Level3Scene");
		}
	}

	public void LoadLevel4()
	{
		if (PlayerPrefs.GetInt(level3High) >= 215)
		{
			Application.LoadLevel("Level4Scene");
		}
	}
}
