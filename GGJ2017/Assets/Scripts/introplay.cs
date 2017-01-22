using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introplay : MonoBehaviour {

	MovieTexture tex;

	// Use this for initialization
	void Start () {
		tex =  (MovieTexture)gameObject.GetComponent<MeshRenderer>().material.mainTexture;
		tex.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if (!tex.isPlaying)
			StartCoroutine("WaitAndStart");
	}

	IEnumerator WaitAndStart()
	{
		yield return new WaitForSeconds(1.5f);
		SceneManager.LoadScene("UIMenu");
	}
}
