using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pacdot : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D co){
        if (co.name == "Pacman"){
            score += 10;
            scoreText.text += score; 
            Destroy(gameObject);
        }
    }
}
