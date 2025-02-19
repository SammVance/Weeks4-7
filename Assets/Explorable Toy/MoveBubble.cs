using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBubble : MonoBehaviour
{
    public float speed = 0.05f;
    public float time = 10;
    public AnimationCurve curve;
    AudioSource audio;
    public AudioClip popSound;

    // Start is called before the first frame update
    void Start()
    {
       audio = GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        //pos.y += speed * Time.deltaTime;

        transform.position = pos;

        if (IsNearScreenEdge())
        {

            PlayAndDestroy();
        }

    }

    public void Size(float t)
    {
        transform.localScale = Vector2.one * curve.Evaluate(t); // Scale is affected by the slider
    }

    bool IsNearScreenEdge()
    {
        // Check to see when the object reaches the edge of the screen
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        return pos.x < 0 || pos.x > 1 || pos.y < 0 || pos.y > 1;
    }

    void PlayAndDestroy()
    {
        GameObject audioObj = new GameObject("BubblePopSound");
        AudioSource audioSource = audioObj.AddComponent<AudioSource>();

        audioSource.clip = popSound;
        audioSource.Play();

        Destroy(audioObj, popSound.length); // Destroy after sound plays
        Destroy(gameObject); // Destroy bubble
    }

}
