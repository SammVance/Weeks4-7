using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Slider slider;
    public SpriteRenderer sprite;
    float t;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        slider.value = t % slider.maxValue;

        sprite = transform.eulerAngles;
        sprite.z += t;
        transform.eulerAngles = rot;
    }
}
