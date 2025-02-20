using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureplateController : MonoBehaviour
{
    bool IsActivated = true;
    bool Isworking;
    public SpriteRenderer sr;
    public GameObject prefab;
    public Transform SpawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        Isworking = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Isworking == true)
        {
            Debug.Log("Its working");
        }
        else{
            Isworking = false;
        }
        GetComponent<PlayerMovement>();

        GameObject player = GameObject.Find("Player");
        Transform playerTransform = player.transform;
        Vector3 pos = player.transform.position;

        if (sr.sprite.bounds.Contains(pos))
        {
            pos.x = 100;
            pos.y = 100;
            Isworking = true;

            IsActivated = true;
        }

        else
            {
                Isworking = false;
            IsActivated = false;
        }


        if(IsActivated == true) 
        {
            Instantiate(prefab, SpawnLocation.position, Quaternion.identity);
   
        }

        }
        
       
    }

