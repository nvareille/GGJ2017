using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.GamePlay;
using Assets.Scripts.ScriptableObjects;

public class addElement : MonoBehaviour {


	public AlimentKind[] arrayElem;
	public int I = 0;

    public void Init(int nbr)
    {
        arrayElem = new AlimentKind[nbr];
    }
	
	public void addElemToArray(CatCatcher tocatch)
	{
	    // (tocatch.asCaught)
		    arrayElem [I] = tocatch.getAliment;
		I++;

	    if (I == arrayElem.Length)
	    {
	        //On gagne
	    }
	}
}