using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiranhaDestroyer : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D c)
	{
		if (c.name.Contains("piranha"))
		{
			Debug.Log ("passe");
			Destroy(c.gameObject);
		}
	}
}
