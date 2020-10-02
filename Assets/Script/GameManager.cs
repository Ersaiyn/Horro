using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
  public int score = 0;
  public Text scoreText;

  public void AddScore() {
    score += 1; //score = score + 1
    scoreText.text = "Coin:" + score.ToString();
  }


  void Start() {

  }

  void Update() {

  }
}