using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net : MonoBehaviour {
    public SpawnPoint spawnPoint;
    public Score score;

    

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Bullet")) {
            score.score++;
            Destroy(other.gameObject);
            spawnPoint.SpawnBullet();
        }
    }
}
