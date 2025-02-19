using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpBubble : MonoBehaviour
{
    private float speed;             // Movement speed
    private float noiseOffsetX;      // Random offset for X movement
    private float noiseOffsetY;      // Random offset for Y movement
    private float noiseSpeed = 0.5f; // Speed of noise variation
    private float moveRange = 0.5f;  // How far it moves from its original position
    private Vector2 direction;       // Main movement direction

    public void Initialize()
    {
        speed = Random.Range(0.5f, 2f);  // Random speed per bubble

        // Set a unique offset for each bubble to have different noise patterns
        noiseOffsetX = Random.Range(0f, 100f);
        noiseOffsetY = Random.Range(0f, 100f);

        // Random movement direction
        float angle = Random.Range(0f, 360f) * Mathf.Deg2Rad;
        direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
    }

    void Update()
    {
        // Use Perlin noise to create smooth random hovering movement
        float noiseX = (Mathf.PerlinNoise(Time.time * noiseSpeed + noiseOffsetX, 0) - 0.5f) * moveRange;
        float noiseY = (Mathf.PerlinNoise(Time.time * noiseSpeed + noiseOffsetY, 0) - 0.5f) * moveRange;

        // Move the bubble in its random direction + perlin noise hover effect
        Vector3 move = new Vector3(direction.x + noiseX, direction.y + noiseY, 0) * speed * Time.deltaTime;
        transform.position += move;
    }
}
