using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardrenderer : MonoBehaviour
{
    private SpriteRenderer[] childRenderers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OrderCards()
    {
        childRenderers = GetComponentsInChildren<SpriteRenderer>();

        for(int i = 0; i < childRenderers.Length; i++)
        {
            childRenderers[i].sortingOrder = i;
        }
    }
}
