using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShop : MonoBehaviour {

	public GameObject[] arrayItem;
	int mainIndex;

	// Use this for initialization
	void Start () {


		//arrayItem = new GameObject[12];
		arrayItem [0].SetActive (true);
		arrayItem [1].SetActive (true);
		arrayItem [2].SetActive (true);

		mainIndex = 2;
	}



	// Update is called once per frame
	void Update () {

//		RaycastHit2D hit = Physics.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);

		if (Input.GetKeyDown (KeyCode.LeftArrow) && mainIndex >= 2) {
			displayByTheLeft ();
		} else if (Input.GetKeyDown (KeyCode.RightArrow) && mainIndex < 15) {
			displayByTheRight ();
			Debug.Log ("passe");
		}
	}

	public void ScreenMouseRay()
	{
		Vector3 mousePosition = Input.mousePosition;
		mousePosition.z = 5f;

	}

	void displayByTheLeft() // gauche
	{
		//if (mainIndex == 9)
		//	mainIndex = 12;
		for (int i = 2; i >= 0; i--) 
		{
			arrayItem [mainIndex - i].SetActive (false);
			Debug.Log(arrayItem [mainIndex - i].name);
		}
		Debug.Log (mainIndex);
		if (mainIndex != 2)
			mainIndex -= 3;


		for (int j = 2; j >= 0; j--) 
		{
			arrayItem [mainIndex - j].SetActive (true); // - 
		}

	}

	void displayByTheRight()
	{
		for (int i = 0; i < 3; i++) {
			arrayItem [mainIndex - i].SetActive (false);
			Debug.Log(arrayItem [mainIndex + i].name);
		}
		//if (mainIndex >= 3)
			mainIndex += 3;
		
		Debug.Log (mainIndex);

		for (int j = 2; j >= 0; j--)
		{
			arrayItem [mainIndex - j].SetActive (true);
		}
	}
}
