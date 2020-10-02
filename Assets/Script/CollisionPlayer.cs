using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour {
  public void OnTriggerEnter(Collider col) {
    if (col.tag == "Player") {
      FindObjectOfType<GameManager>().AddScore();
      Destroy(gameObject);
    }
  }
  void Start() {

  }

  void Update() {

  }
}