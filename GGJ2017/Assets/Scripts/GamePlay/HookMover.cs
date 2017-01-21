using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlay;
using UnityEngine;

public class HookMover : MonoBehaviour
{
    public float SpeedModifier = 1f;

    public TetherMovement TetherMovement;
    public Animator Animator;
    public Animation A;

    public void Update()
    {
        float tether = Input.GetAxis("Horizontal");

        TetherMovement.Transform.position += new Vector3(tether, 0, 0) * SpeedModifier * Time.deltaTime;
        TetherMovement.AddTether(-tether);

        if (Input.GetKey(KeyCode.Space))
        {
            Animator.SetBool("Casting", true);
        }
        else
        {
            Animator.SetBool("Casting", false);
        }
    }
}
