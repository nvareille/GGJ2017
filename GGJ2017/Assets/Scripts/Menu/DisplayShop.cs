using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayShop : MonoBehaviour {

	public GameObject GOMenu;
	public GameObject GOShop;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowShop()
    {
		GOMenu.SetActive (false);
		GOShop.SetActive (true);
	}

	public void ShowMenu(){
		GOMenu.SetActive (true);
		GOShop.SetActive (false);
	}
}
