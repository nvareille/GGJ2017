using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiranhaSpwaner : MonoBehaviour {

	public GameObject piranha;
	public float Timer;
	// Use this for initialization
	void Start () {

		Timer = 5;

	}
	
	// Update is called once per frame
	void Update () {

		Timer -= Time.deltaTime;

		if (Timer < 0) {
			GameObject obj = Instantiate (piranha);
			Timer = 5;
		}


	}
}
