using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateColorObjects : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
//        rend.sharedMaterial = material[0];
    }

    public void WhiteColor()
    {
        rend.sharedMaterial = material[0];
    }

    public void BlackColor()
    {
        rend.sharedMaterial = material[1];
    }

}
