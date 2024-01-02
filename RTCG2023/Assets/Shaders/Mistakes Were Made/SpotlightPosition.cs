using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightPosition : MonoBehaviour
{
    public Material material;
    public Light spotlight;

    // Update is called once per frame
    void Update()
    {
        if (material != null && spotlight != null)
        {
            material.SetVector("_SpotlightPosition", spotlight.transform.position);

            float coneAngle = spotlight.spotAngle;
            material.SetFloat("_ConeAngle", coneAngle);
        }        
    }
}
