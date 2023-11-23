using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D collision) {

       // if (collision.gameObject.tag == "Obstacle") {
            Debug.Log("Hit Obstacle");
      //  }
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        Debug.Log("Triggered");
    }
}
