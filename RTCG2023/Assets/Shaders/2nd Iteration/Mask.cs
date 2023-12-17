using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castRay = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if(Physics.Raycast(castRay,out hit, Mathf.Infinity))
        {
            transform.position = hit.point * 1.4f + Vector3.forward;
            transform.LookAt(hit.collider.gameObject.transform.position + Vector3.forward);
        }
    }
}
