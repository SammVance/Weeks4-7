using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEditor;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = -5f;
    public float hour = 0f;
    public float interval = 0.1f;
    public AudioSource chime;
    public AudioClip[] clip;
    public SpriteRenderer bird;

    // Start is called before the first frame update
    void Start()
    {
        bird.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
        hour += interval * Time.deltaTime;

        if (hour >= 1)
        {
            for (int hour = 0; hour < clip.Length; hour++)
            {
                chime.PlayOneShot(clip[hour]);
            }
        }

        if (chime.isPlaying)
        {
            bird.enabled = true;
        }
        else
        {
            bird.enabled = false;
        }

        if (hour >= 12)
        {
            hour = 0;
        }

    }
}
