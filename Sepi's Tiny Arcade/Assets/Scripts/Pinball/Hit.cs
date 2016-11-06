using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {
    GameObject ball;
    public int type;
    void Awake () {
        ball = GameObject.FindGameObjectWithTag("Ball");
    }
	void OnTriggerEnter (Collider ballHit) {
        if(ballHit.transform.tag == "Ball") {
            ball.GetComponent<Ball>().Hit(type);
            print(type);
        }
    }
}
