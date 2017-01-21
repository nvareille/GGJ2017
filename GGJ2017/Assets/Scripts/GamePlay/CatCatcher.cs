using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.GamePlay
{
    public class CatCatcher : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D c)
        {
            Debug.Log(c.name);

            if (c.gameObject.name.Contains("aliment"))
            {
                c.gameObject.GetComponent<Aliment>().Parent.GetComponent<Animator>().SetBool("Caught", true);
            }
        }
    }
}
