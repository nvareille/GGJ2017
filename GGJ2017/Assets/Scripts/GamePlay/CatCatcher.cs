using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts.ScriptableObjects;
using Assets.Scripts.UI;

namespace Assets.Scripts.GamePlay
{
    public class CatCatcher : MonoBehaviour
    {
		public bool asCaught = false;
		public AlimentKind getAliment;
		public addElement _add;

        public UIAlimentRequirement UIAliment;

		void Start()
		{
			if (PlayerPrefs.GetString("CurrentSkin") != "")
				GameObject.Find("Skin" + PlayerPrefs.GetString("CurrentSkin")).GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
		}

        void OnTriggerEnter2D(Collider2D c)
        {
            Debug.Log(c.name);

            if (c.gameObject.name.Contains("aliment"))
            {
                c.gameObject.GetComponent<Aliment>().Parent.GetComponent<Animator>().SetBool("Caught", true);
				asCaught = true;
				getAliment = c.gameObject.GetComponent<Aliment>().AlimentKind;
				_add.addElemToArray (this);
                UIAliment.UpdatePick(_add.I - 1, getAliment);
            }
        }
    }
}
