using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.GamePlay;
using Assets.Scripts.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class UIAlimentRequirement : MonoBehaviour
    {
        public GameObject UIDrawerPrefab;
        public Material Mat;

        public EndGame EndGame;

        public List<UIAliment> Aliments = new List<UIAliment>();
        public List<AlimentKind> Got = new List<AlimentKind>();

        public void Init(List<AlimentKind> l)
        {
            foreach (AlimentKind kind in l)
            {
                GameObject o = Instantiate(UIDrawerPrefab);
                UIAliment a = o.GetComponent<UIAliment>();
                RawImage i = o.GetComponent<RawImage>();
                Material m = Instantiate(Mat);

                a.Init(kind);
                i.material = m;
                o.transform.SetParent(transform);
                Aliments.Add(a);
            }
        }

        public void UpdatePick(int pick, AlimentKind k)
        {
            if (Aliments[pick].Aliment.Name == k.Name)
			{
                Aliments[pick].gameObject.GetComponent<RawImage>().color = Color.green;
				PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 1);
			}
			else
                Aliments[pick].gameObject.GetComponent<RawImage>().color = Color.red;
            Got.Add(k);
            if (Got.Count == Aliments.Count)
            {
                EndGame.FinishGame();
            }
        }
    }
}
