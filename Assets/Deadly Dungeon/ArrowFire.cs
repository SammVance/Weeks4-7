using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ArrowFire : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = transform.position;
        Pos.x += 0.7f;
        transform.position = Pos;

        
    }
}
