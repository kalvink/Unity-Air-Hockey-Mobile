using UnityEngine;
using System.Collections;

public class TouchDrag : MonoBehaviour
{

    // Update is called once per frame
    public float speed = 0.01F;
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
        }
    }
}

