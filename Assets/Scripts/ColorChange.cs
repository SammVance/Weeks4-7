using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer spriterenderer;

    // Start is called before the first frame update
    
    public void On()
    {
        spriterenderer.color = Random.ColorHSV();
    }
}
