using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plus : MonoBehaviour
{

    public float maxLife = 100;
    public float curLife;

    Collision collision;
    public Image LiveUI;

    void Start()
    {
        collision = GetComponent<Collision>();
        curLife = maxLife;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(gameObject.tag=="Bot")
        Destroy(gameObject);
    }    

    public void AddEnergy()
    {
        curLife = maxLife;
    }

}