using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medecine : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void UseBattery()
    {
        player.GetComponentInChildren<Plus>().AddEnergy();
        Destroy(gameObject);
    }

    void Update()
    {

    }
}