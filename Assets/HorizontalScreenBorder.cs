using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalScreenBorder : MonoBehaviour {
    public bool isRight;
    public bool stretch;
    public float margin = 0;

    private void Update() {
        float x = 0;
        if (isRight)
            x = Screen.width;

        Vector2 point = Camera.main.ScreenToWorldPoint(new Vector2(x, Screen.height / 2));
        if (isRight)
            point.x += margin;
        else
            point.x -= margin;

        float height = Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y - Camera.main.ScreenToWorldPoint(Vector2.zero).y;

        Vector2 scale = this.transform.localScale;
        scale.y = height;
        Vector2 position = this.transform.position;
        position.x = point.x;

        this.transform.position = position;
        if (stretch)
            this.transform.localScale = scale;
    }
}
