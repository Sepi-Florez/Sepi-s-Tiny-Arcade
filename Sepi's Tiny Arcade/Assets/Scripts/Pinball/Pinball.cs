using UnityEngine;
using System.Collections;

public class Pinball : MonoBehaviour {

    public Animator[] anim;
    public GameObject ball;


    public float thrust;
    public float thrustRate;

    public bool start = true;

    void Awake() {
        ball = GameObject.FindGameObjectWithTag("Ball");
    }

    void Update () {
        _Input();
	}
    void _Input () {
        if (Input.GetButtonDown("Fire1")){
            Activate(0);
        }
        if (Input.GetButtonDown("Fire2")) {
            Activate(1);
        }
        if (Input.GetButtonDown("Jump")) {
            Activate(0);
            Activate(1);
        }
        if (Input.GetButtonUp("Fire1")) {
            Deactivate(0);
        }
        if (Input.GetButtonUp("Fire2")) {
            Deactivate(1);
        }
        if (Input.GetButtonUp("Jump")) {
            Deactivate(0);
            Deactivate(1);
        }
        if(start) {
            if (Input.GetButton("Start")) {
                thrust += thrustRate;
                print("Thrust");
            }
            if (Input.GetButtonUp("Start")) {
                ball.transform.GetComponent<Rigidbody2D>().isKinematic = false; 
                ball.transform.GetComponent<Rigidbody2D>().AddForce(ball.transform.up * thrust);
                thrust = 0;
            }
        }

    }
    void Activate (int op) {
        anim[op].SetBool("Flip", true);
    }
    void Deactivate (int op) {
        anim[op].SetBool("Flip", false);
    }
    public void Begun() {
        start = false;
    }

}
