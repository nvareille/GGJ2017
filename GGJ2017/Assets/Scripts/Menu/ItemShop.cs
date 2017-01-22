using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemShop : MonoBehaviour {

	public GameObject[] arrayItem;
	public int[] price;
	public string[] nameOfTheSkin;
	public string actualSkin;
	int mainIndex;
	int indexBuy;

	// Use this for initialization
	void Start () {

		indexBuy = 0;
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
		} else if (Input.GetKeyDown (KeyCode.RightArrow) && mainIndex < 18) {
			displayByTheRight ();
			Debug.Log ("passe");
		}
	}

	public void confirmSkin(GameObject _button)
	{
		for (int i = 0; i < 21; i++) {
			//if (nameOfTheSkin [i] == _button.transform.parent.gameObject.name) {
			if (PlayerPrefs.HasKey(_button.transform.parent.gameObject.name)) {
				actualSkin = _button.transform.parent.gameObject.name;
				Debug.Log ("skin confirmed : " + actualSkin);
				PlayerPrefs.SetString("CurrentSkin", _button.transform.parent.gameObject.GetComponent<RawImage>().texture.name);
			}
		}
		if (actualSkin != _button.transform.parent.gameObject.name)
			Debug.Log ("you must buy the skin");
	}

	public void buySkin(GameObject _coin)
	{
		// condition pour l'achat
		if (PlayerPrefs.GetInt("Money") >= 4)
		{
			nameOfTheSkin [indexBuy] = _coin.transform.parent.gameObject.name;
			PlayerPrefs.SetInt(_coin.transform.parent.gameObject.name, 1);
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 4);
		}
		else
			print("Not enough money");
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
