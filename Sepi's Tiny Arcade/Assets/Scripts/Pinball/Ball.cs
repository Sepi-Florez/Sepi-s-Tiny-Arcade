using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public GameObject ballFab;

    public Vector3 spawnPos;

    public void Hit(int type) {
        switch (type) {
            case 0:
                transform.GetComponent<Pinball>().Begun();
                print("Begun");
                break;
            case 1:
                Restart();
                break;

        }
    }

    void Restart() {

        transform.GetComponent<Pinball>().ball = (GameObject)Instantiate(ballFab, spawnPos, Quaternion.identity);

        Destroy(gameObject);

    }
}
