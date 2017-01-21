using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    [Serializable, CreateAssetMenu(menuName = "AlimentKind")]
    public class AlimentKind : ScriptableObject
    {
        public string Name;
        public Sprite Texture;
        public Sprite EndTexture;
        public float[] Size;
    }
}
