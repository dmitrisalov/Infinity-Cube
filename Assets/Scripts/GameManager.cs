using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject player;
    public GameObject score;
    public GameObject restartButton;
    public GameObject startButton;

    private PlayerMovement movementScript;
    private Score scoreScript;

    void Start() {
        movementScript = player.GetComponent<PlayerMovement>();
        scoreScript = score.GetComponent<Score>();
    }

    void Update() {
        if (Input.GetKey("escape")) {
            Application.Quit();
        }
    }

    public void EndGame() {
        movementScript.enableMovement = false;
        scoreScript.scoreIncrease = false;
        restartButton.SetActive(true);
    }

    public void Restart() {
        SceneManager.LoadScene("MainScene");
        restartButton.SetActive(false);
        startButton.SetActive(false);
        score.SetActive(true);
    }
}
