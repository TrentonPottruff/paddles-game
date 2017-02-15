using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour {
    public Vector2 direction;
    public float speed;

    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = direction.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D col) {

        Vector2 ballVector = direction * -1f;
        Vector2 normalVector = col.contacts[0].normal;
        Debug.DrawLine(col.contacts[0].point, (col.contacts[0].point + ballVector), Color.blue, 100000);
        Debug.DrawLine(col.contacts[0].point, (col.contacts[0].point + normalVector), Color.green, 100000);
        float angle = Vector2.Angle(ballVector, normalVector);
        Vector3 cross = Vector3.Cross(ballVector, normalVector);
        float multiplier = 1f;
        if (cross.z < 0)
            multiplier = -1f;

        Vector2 newVector = Quaternion.Euler(0, 0, (angle * 2) * multiplier) * ballVector;
        if (col.gameObject.tag.Equals("Paddle"))
            newVector = Quaternion.Euler(0, 0, (-Vector2.Angle(col.transform.position, col.contacts[0].point)) * multiplier) * ballVector;

        Debug.DrawLine(col.contacts[0].point, (col.contacts[0].point + newVector), Color.red, 100000);
        direction = newVector.normalized;
        rb.velocity = direction * speed;
    }
}