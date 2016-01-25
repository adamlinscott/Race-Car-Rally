using UnityEngine;
using System.Collections;
using System;

public class CarAngleScript : MonoBehaviour 
{
	public GameObject[] frontLevels;
	public GameObject[] backLevels;

	// Update is called once per frame
	void Update () 
	{
		if (Convert.ToDouble(GetComponent<Rigidbody2D>().rotation.ToString()) > 60 && Convert.ToDouble(GetComponent<Rigidbody2D>().rotation.ToString()) < 240)
		{
			foreach (GameObject o in frontLevels)
			{
				o.SetActive(false);
			}
			foreach (GameObject o in backLevels)
			{
				o.SetActive(true);
			}
			Debug.Log("forward");
		}
		else
		{
			foreach (GameObject o in frontLevels)
			{
				o.SetActive(true);
			}
			foreach (GameObject o in backLevels)
			{
				o.SetActive(false);
			}
			Debug.Log("back");
		}
	}
}
