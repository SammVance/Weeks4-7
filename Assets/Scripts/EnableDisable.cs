using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public SpriteRenderer sprite;
    public EnableDisable script;
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sprite.enabled = false;
            // script.enabled = false;
            go.SetActive(false);
            // go.activeInHierarchy = Conditional, used in if statements
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sprite.enabled = true;
            // script.enabled = true;
            go.SetActive(true);
        }


    }
}
