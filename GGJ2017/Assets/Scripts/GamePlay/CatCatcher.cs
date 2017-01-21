using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts.ScriptableObjects;

namespace Assets.Scripts.GamePlay
{
    public class CatCatcher : MonoBehaviour
    {
		public bool asCaught = false;
		public AlimentKind getAliment;
		public addElement _add;
        void OnTriggerEnter2D(Collider2D c)
        {
            Debug.Log(c.name);

            if (c.gameObject.name.Contains("aliment"))
            {
                c.gameObject.GetComponent<Aliment>().Parent.GetComponent<Animator>().SetBool("Caught", true);
				asCaught = true;
				getAliment = c.gameObject.GetComponent<Aliment>().AlimentKind;
				_add.addElemToArray (this);
            }
        }
    }
}
