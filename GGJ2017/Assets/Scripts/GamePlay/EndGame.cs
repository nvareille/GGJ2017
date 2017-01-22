using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.GamePlay
{
    public class EndGame : MonoBehaviour
    {
        public Animator Waves;
        public Animator Cat;
        public Animator Assiette;
		public Animator Money;

        public UIAlimentRequirement UI;
        public alimentSpawner Spawner;

        public GameObject Food;
        public GameObject ExitButton;

        public bool EndGameBool;

        public AudioClip Win;
        public AudioSource Source;

        public float Timer;
        private int Count = 0;

        public void FinishGame()
        {
            Cat.SetBool("EndGame", true);
            Waves.SetBool("EndGame", true);
			Assiette.SetBool("EndGame", true);
            Money.SetBool("EndGame", true);
			Money.transform.Find("MoneyText").gameObject.GetComponent<UICountMoney>().setTotalMoney();
            Spawner.gameObject.SetActive(false);
            ExitButton.SetActive(true);
            Source.clip = Win;
            
            Source.Play();
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

        public void Return()
        {
            SceneManager.LoadScene(2);
        }
    }
}
