using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour {

	public bool play;
	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!play)
	    {
	        Debug.Log("Deactivated");
	        Destroy(gameObject.transform.parent.gameObject);
	    }
    }
}
