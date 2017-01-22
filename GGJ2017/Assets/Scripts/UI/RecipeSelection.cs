using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.GamePlay;
using Assets.Scripts.ScriptableObjects;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.UI
{
    public class RecipeSelection : MonoBehaviour
    {
        public Recipe[] Recipes;
        public RecipeManager Manager;

        public void SelectRecipe(int r)
        {
            Manager.Recipe = Recipes[r];
            DontDestroyOnLoad(Manager.gameObject);
            SceneManager.LoadScene("GameScene");
        }

        public void Return()
        {
            SceneManager.LoadScene("UIMenu");
        }
    }
}
