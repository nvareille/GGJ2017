using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.UI;
using UnityEngine;

namespace Assets.Scripts.GamePlay
{
    public class EndGame : MonoBehaviour
    {
        public Animator Waves;
        public Animator Cat;
        public Animator Assiette;

        public UIAlimentRequirement UI;
        public alimentSpawner Spawner;

        public GameObject Food;

        public bool EndGameBool;

        public float Timer;
        private int Count = 0;

        public void FinishGame()
        {
            Cat.SetBool("EndGame", true);
            Waves.SetBool("EndGame", true);
            Assiette.SetBool("EndGame", true);
            Spawner.gameObject.SetActive(false);
        }

        public void Update()
        {
            if (!EndGameBool && Input.GetKeyDown(KeyCode.Alpha0))
            {
                FinishGame();
            }

            if (EndGameBool)
            {
                Timer -= Time.deltaTime;

                if (Timer < 0 && Count < UI.Aliments.Count)
                {
                    Timer = 3;
                    GameObject o = Instantiate(Food);

                    FoodFaller f = o.GetComponent<FoodFaller>();
                    f.Init(12, UI.Got[Count]);
                    ++Count;
                }
            }
        }
    }
}
