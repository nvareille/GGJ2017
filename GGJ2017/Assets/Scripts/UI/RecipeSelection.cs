using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.UI
{
    public class RecipeSelection : MonoBehaviour
    {
        public void Return()
        {
            SceneManager.LoadScene(0);
        }
    }
}
