using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour 
{
	//variables
	public float carSpeed;
	public float traverseSpeed;
	public static bool isInGame = false;

	void Start()
	{
		isInGame = false; //pause game
	} //end Start

	void Update () //Update method is called once per frame
	{
		if (isInGame == false && Input.GetKey(KeyCode.Space) || Input.touchCount > 0) 
		{
			isInGame = true; //start game
		} //end if

		if (isInGame == true) //whilst not on pause
		{		
			Time.timeScale = 1;
			int a = 1; //constant
			if (Input.GetKey(KeyCode.Space) || Input.touchCount > 0) //if key pressed negative constant
				a = -1;

			 //new correctly signed traverse speed

			GetComponent<Rigidbody2D>().transform.Rotate(0, 0, (a * traverseSpeed)); //rotate car

			GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().transform.right * carSpeed; //move car forward
		} //end if

	} //end Update
} //end class
