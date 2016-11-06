using UnityEngine;
using System.Collections;

public class BallCam : MonoBehaviour {
    private GameObject ball;
    void Awake() {
        ball = GameObject.FindGameObjectWithTag("Ball");
    }
    void Update() {
        Vector3 camPos = transform.position;
        camPos.y = ball.transform.position.y;
        transform.position = camPos;
    }
}

