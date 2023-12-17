using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    [SerializeField] GameObject FLlight;
    private bool FLActive = true;

    // Start is called before the first frame update
    void Start()
    {
        FLlight.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (FLActive == true)
            {
                FLlight.gameObject.SetActive(false);
                FLActive = false;
            }
            else
            {
                FLlight.gameObject.SetActive(true); 
                FLActive = true;
            }
        }
    }
}
