using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {
    public bool isTop;

    private void Update() {
        float y = 0;
        if (isTop)
            y = Screen.height;

        Vector2 point = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, y));
        if (isTop)
            point.y += 0.5f;
        else
            point.y -= 0.5f;

        float width = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x - Camera.main.ScreenToWorldPoint(Vector2.zero).x;

        Vector2 scale = this.transform.localScale;
        scale.x = width;

        this.transform.position = point;
        this.transform.localScale = scale;
    }
}
