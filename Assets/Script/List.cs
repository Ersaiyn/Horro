using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class List : MonoBehaviour
{

    public Image Icon;

    void Start()
    {
        if(Icon != null)
        Icon.enabled = false;
    }

    public void MapActive()
    {
        if(Icon != null)
        Icon.enabled = true;
    }
}
