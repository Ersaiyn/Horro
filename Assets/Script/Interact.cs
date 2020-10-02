using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{

    public LayerMask interactLayer;
    public float InteractDistance;
    public Image InteractIcon;

    void Start()
    {
        if(InteractIcon != null)
        InteractIcon.enabled = false;
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, InteractDistance, interactLayer))
        {
            if(InteractIcon != null)
            InteractIcon.enabled = true;

            if(Input.GetKeyDown(KeyCode.E))
            {
                if(hit.collider.tag == "Battery")
                {
                    hit.collider.GetComponent<Buttery>().UseBattery();
                }
                if(hit.collider.tag == "List")
                {
                    hit.collider.GetComponent<List>().MapActive();
                }
            }
        }
        else
        {
            if(InteractIcon != null)
            InteractIcon.enabled = false;
        }
    }
}
