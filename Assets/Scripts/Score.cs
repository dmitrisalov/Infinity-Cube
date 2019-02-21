using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public bool scoreIncrease = true;
    public GameObject player;
    public float distancePerScore;

    private Text scoreText;
    private int currentScore;

    // Start is called before the first frame update
    void Start() {
        scoreText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        UpdateCurrentScore();
        scoreText.text = currentScore.ToString();
    }

    void UpdateCurrentScore () {
        if (scoreIncrease) {
            currentScore = (int)(player.transform.position.z / distancePerScore);
        }
    }
}
