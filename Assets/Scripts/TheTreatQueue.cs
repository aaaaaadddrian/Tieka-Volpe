using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class TheTreatQueue : MonoBehaviour
{

    
    public SpriteRenderer[] childRenderers;
    
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            childRenderers[i] = transform.GetChild(i).GetComponent<SpriteRenderer>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void updateQueue(GameObject treat)
    {
        
    }
}
