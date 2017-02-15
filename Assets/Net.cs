using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net : MonoBehaviour {
    public Score score;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Bullet")) {
            score.score++;
        }
    }
}
