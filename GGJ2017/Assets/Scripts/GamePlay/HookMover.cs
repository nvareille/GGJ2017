using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlay;
using UnityEngine;

public class HookMover : MonoBehaviour
{
    public float SpeedModifier = 1f;

    public AudioSource DropAudio;

    public TetherMovement TetherMovement;
    public Animator Animator;

    public float[] Limits;

    public void Update()
    {
        float tether = Input.GetAxis("Horizontal");
        
        TetherMovement.transform.position += new Vector3(tether, 0, 0) * SpeedModifier * Time.deltaTime;
        if (TetherMovement.transform.position.x < Limits[0])
            TetherMovement.transform.position = new Vector3(Limits[0], TetherMovement.transform.position.y, 0);
        else if (TetherMovement.transform.position.x > Limits[1])
            TetherMovement.transform.position = new Vector3(Limits[1], TetherMovement.transform.position.y, 0);
        else
            TetherMovement.AddTether(-tether);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Animator.SetBool("Casting", true);
            DropAudio.Play();
        }
        else
            Animator.SetBool("Casting", false);
    }
}
