using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayShop : MonoBehaviour {

	public GameObject GOMenu;
	public GameObject GOShop;

    public AudioClip Shop;
    public AudioClip Menu;
    public AudioSource Source;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowShop()
	{
	    Source.clip = Shop;
        Source.Play();
		GOMenu.SetActive (false);
		GOShop.SetActive (true);
	}

	public void ShowMenu()
	{
	    Source.clip = Menu;
        Source.Play();
		GOMenu.SetActive (true);
		GOShop.SetActive (false);
	}
}
