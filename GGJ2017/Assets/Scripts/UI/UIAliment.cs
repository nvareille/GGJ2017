using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class UIAliment : MonoBehaviour
    {
        public RawImage Image;

        public AlimentKind Aliment;


        public void Init(AlimentKind alim)
        {
            Aliment = alim;
            Image.texture = Aliment.Texture.texture;
        }
    }
}
