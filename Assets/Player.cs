using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private void Update() {
        Vector2 newPosition = this.transform.position;
        newPosition.y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        this.transform.position = newPosition;
    }
}