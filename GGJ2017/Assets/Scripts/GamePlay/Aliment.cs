using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.ScriptableObjects;
using UnityEngine;

namespace Assets.Scripts.GamePlay
{
    public class Aliment : MonoBehaviour
    {
        public AlimentKind AlimentKind;
        public SpriteRenderer Render;

        public void Init(AlimentKind kind)
        {
            AlimentKind = kind;
            Render.sprite = AlimentKind.Texture;
        }
    }
}
