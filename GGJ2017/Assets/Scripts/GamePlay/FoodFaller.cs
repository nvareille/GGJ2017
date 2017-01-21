using Assets.Scripts.ScriptableObjects;
using UnityEngine;

namespace Assets.Scripts.GamePlay
{
    public class FoodFaller : MonoBehaviour
    {
        public SpriteRenderer Renderer;
        public float ToFall;
        public float FallSpeed = 1f;
        public float RotationSpeed = 1f;

        public void Init(float Y, AlimentKind alim)
        {
            transform.position = new Vector3(0, Y, 0);
            transform.localScale = new Vector3(alim.Size[0], alim.Size[1], 0);
            ToFall = Y + 1;
            Renderer.sprite = alim.EndTexture;
            RotationSpeed *= Random.Range(1, 3);
            if (Random.Range(-1, 1) == 0)
                RotationSpeed *= -1;
        }

        public void Update()
        {
            if (ToFall > 0)
            {
                ToFall -= Time.deltaTime * FallSpeed;
                transform.position -= new Vector3(0, Time.deltaTime * FallSpeed, 0);
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, 0, RotationSpeed * Time.deltaTime));
            }
        }
    }
}
