using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Ambiance
{
    public class SeagullPlayer : MonoBehaviour
    {
        public AudioSource Source;
        public AudioClip[] Clips;
        private int Actual = -1;
        private float Waiting = 3;

        public void Update()
        {
            if (Waiting < 0)
            {
                ++Actual;
                if (Actual >= Clips.Length)
                    Actual = 0;

                Waiting = Clips[Actual].length + 5;
                Source.clip = Clips[Actual];
                Source.Play();
            }

            Waiting -= Time.deltaTime;
        }
    }
}
