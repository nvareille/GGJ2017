using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alimentSpawner : MonoBehaviour {

	public GameObject aliment;
	private float Timer;

	// Use this for initialization
	void Start () {
		Timer = Time.time + 3;
	}
	
	// Update is called once per frame
	void Update () {


		if (Timer < Time.time) 
		{
			Instantiate (aliment, transform.position, transform.rotation);
			Timer = Time.time + 3;
		}
	}

	void spawn ()
	{

	}
}
