using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public GameObject objectToFollow;
    public Vector3 initialOffset;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.position = newCamPosition();
    }

    Vector3 newCamPosition() {
        return objectToFollow.transform.position + initialOffset;
    }
}
