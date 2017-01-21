using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlay;
using Assets.Scripts.ScriptableObjects;
using Assets.Scripts.UI;
using UnityEngine;

public class alimentSpawner : MonoBehaviour
{
    public Recipe Recipe;
    public addElement Adder;
    public List<AlimentKind> AlimentKinds;
    public UIAlimentRequirement Requirement;
	public GameObject aliment;
	private float Timer;

	// Use this for initialization
	void Start ()
    {
        AlimentKinds = new List<AlimentKind>();
        Adder.Init(Recipe.Ingredients.Count);
		Timer = 3;
        Requirement.Init(Recipe.Ingredients);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (AlimentKinds.Count == 0)
        {
            AlimentKinds = Recipe.GetList();
        }

        Timer -= Time.deltaTime;

        if (Timer < 0)
		{
			GameObject obj = Instantiate (aliment);
            
		    Aliment ali = obj.transform.GetChild(0).GetComponent<Aliment>();
		    ali.Init(AlimentKinds[0]);
            AlimentKinds.RemoveAt(0);
            Timer = 3;
		}
	}
}
