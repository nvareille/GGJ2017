using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolPlayer : MonoBehaviour
{
    public AudioSource Source;
    public List<AudioClip> Clips;

    void Start()
    {
        Source.clip = Clips[0];
        Clips.RemoveAt(0);
        Source.Play();
    }

    void Update ()
    {
        if (!Source.isPlaying)
        {
            Source.clip = Clips[0];
            Clips.RemoveAt(0);
            if (Clips.Count == 0)
                Source.loop = true;
            Source.Play();
        }
	}
}
