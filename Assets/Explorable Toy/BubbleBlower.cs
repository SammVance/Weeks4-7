using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleBlower : MonoBehaviour
{
    public GameObject prefab; // Public allows me to input my bubble prefab

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Spawn()
    {
        Instantiate(prefab);
        // Spawns the bubble prefab
        // I can grab this Spawn() function from the button
    }
}

