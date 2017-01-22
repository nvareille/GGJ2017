using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.GamePlay
{
    public class TetherMovement : MonoBehaviour
    {
        public Transform Transform;

        public float TetherModifier = 1f;
        public float InertModifier = 1f;
        public float LimitedAngle = 45f;
        public float Tether;

        public float Pendulum;
        public bool PendulumWay;

        private bool Moved;

        public void Start()
        {
            PendulumWay = false;
        }

        public void AddTether(float strenght)
        {
            Moved = true;
            Tether += strenght * 2;
            Pendulum += Math.Abs(strenght);
            if (Pendulum > 1)
                Pendulum = 1;
            if (Tether > LimitedAngle)
                Tether = LimitedAngle;
            if (Tether < -LimitedAngle)
                Tether = -LimitedAngle;
        }

        public void AffectPendulum()
        {
            //Pendulum += Time.deltaTime * 100;
        }

        public void Update()
        {
            AffectPendulum();

            float f = Tether * Pendulum;

            Transform.rotation = Quaternion.Euler(new Vector3(0, 0, (f < 1 && f > -1 ? 0 : f)));
            ReduceTether();
        }

        public void ReduceTether()
        {
            Tether -= (Tether > 0 ? Time.deltaTime : -Time.deltaTime) * TetherModifier;
            if (Tether <= 0.1 && Tether >= -0.1)
                Tether = 0;
        }
    }
}
