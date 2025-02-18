using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBubble : MonoBehaviour
{
    public float speed = 0.05f;
    public float time = 10;
    public AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, time); // Destroy after 10 seconds
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        pos.y += speed * Time.deltaTime;

        transform.position = pos;

    }

    public void Size(float t)
    {
        transform.localScale = Vector2.one * curve.Evaluate(t); // Scale is affected by the slider
    }
}
