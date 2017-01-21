using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts.ScriptableObjects
{
    [Serializable, CreateAssetMenu(menuName = "Recipe")]
    public class Recipe : ScriptableObject
    {
        public string Name;
        public List<AlimentKind> Ingredients;
        public List<AlimentKind> AvailableIngredients;

        public List<AlimentKind> GetList()
        {
            AlimentKind[] aliments = new AlimentKind[AvailableIngredients.Count];
            AlimentKind k;
            int count = 0;

            foreach (AlimentKind kind in AvailableIngredients)
            {
                aliments[count] = kind;
                ++count;
            }

            count = 0;
            while (count < aliments.Length)
            { 
                int t = Random.Range(0, aliments.Length - 1);

                k = aliments[count];
                aliments[count] = aliments[t];
                aliments[t] = k;
                ++count;
            }

            return aliments.ToList();
        }
    }
}
