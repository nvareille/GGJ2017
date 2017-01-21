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
            Debug.Log(c.gameObject.name);
        }
    }
}
