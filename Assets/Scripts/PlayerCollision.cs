using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public GameObject manager;

    private GameManager managerScript;

    void Start() {
        managerScript = manager.GetComponent<GameManager>();
    }

    void OnCollisionEnter(Collision other) {
        if (other.collider.tag == "Obstacle") {
            managerScript.EndGame();
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.GetComponent<Collider>().tag == "Obstacle") {
            managerScript.EndGame();
        }
    }
}
