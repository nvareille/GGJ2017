using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  Assets.Scripts.GamePlay;
using Assets.Scripts.ScriptableObjects;

public class addElement : MonoBehaviour {


	public AlimentKind[] arrayElem;
	public CatCatcher tocatch;
	int i = 0;

	// 
	// Use this for initialization
	void Start () {
		arrayElem = new AlimentKind[5];	

	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void defineTheSizeOfArray()
	{


	}

	public void addElemToArray()
	{
			if (tocatch.asCaught)
				arrayElem [i] = tocatch.getAliment;
			i++;
	}
}