using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlay;
using Assets.Scripts.ScriptableObjects;
using UnityEngine;

public class alimentSpawner : MonoBehaviour
{
    public AlimentKind[] AlimentKinds;
	public GameObject aliment;
	private float Timer;

	// Use this for initialization
	void Start ()
    {
		Timer = 3;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Timer -= Time.deltaTime;

        if (Timer < 0) 
		{
			GameObject obj = Instantiate (aliment);
            
		    Aliment ali = obj.transform.GetChild(0).GetComponent<Aliment>();
		    ali.Init(AlimentKinds[0]);
            Timer = 3;
		}
	}
}
