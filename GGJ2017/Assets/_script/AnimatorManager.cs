using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour {

	public bool play;
	// Use this for initialization
	void Start () {
		//_play = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//_play = this.GetComponent<Animator> ().GetBool ("stopAliment");
		//Debug.Log (_play);
		if (!play)
			Destroy (this.gameObject);
		//if (this.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("animAliment"))
		//	Destroy (this);
	}
	void Lol()
	{
		/*if (!_play) {
			Debug.Log ("passe");
			Destroy (this.gameObject);
		}*/
	}
}
