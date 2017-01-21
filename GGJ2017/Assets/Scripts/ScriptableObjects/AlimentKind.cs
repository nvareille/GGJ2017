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
        public Texture2D Texture;

    }
}
