using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AI : MonoBehaviour {
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        Vector2 bulletPosition = GameObject.FindGameObjectWithTag("Bullet").transform.position;
        float yDifference = this.transform.position.y - bulletPosition.y;

        if (yDifference > 0) {
            rb.velocity = Vector2.down;
        } else if (yDifference < 0) {
            rb.velocity = Vector2.up;
        }
    }
}