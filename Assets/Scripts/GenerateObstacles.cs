using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour {
    public int numberToGenerate;
    public float startPosition;
    public float distanceBetweenObstacles;
    public GameObject[] obstaclePool;

    // Start is called before the first frame update
    void Start() {
        for (int i = 0; i < numberToGenerate; i++) {
            Vector3 position = new Vector3(0, 0, startPosition + i * distanceBetweenObstacles);

            // Instantiate a randomly-selected obstacle at position
            int index = Random.Range(0, obstaclePool.Length);
            Instantiate(obstaclePool[index], position, Quaternion.identity);
        }
    }
}
