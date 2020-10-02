using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
  // Start is called before the first frame update
  public int coins = 0;

  void OnTriggerEnter(Collider obj) {
    if (obj.tag == "Coin") {
      coins++;
      Debug.Log("Your coins: " + coins);
      Destroy(obj.gameObject);
    }
  }

  void Start() {

  }

  // Update is called once per frame
  void Update() {

  }
}
