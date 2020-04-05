using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragP1 : MonoBehaviour
{
    //public bool isPicked;
    //public float botX, botY;
    //public Vector2 v;
    public Transform botRacket;
    public Rect bottom;

    void Start()
    {
        bottom = new Rect(0, 0, Screen.width, Screen.height / 2);

    }

    void Update()
    {
        if (Input.touchCount >= 1) //checks for touches (prevents the error)
        {
            if (bottom.Contains(Input.GetTouch(0).position))
            {
                Debug.Log("Bot touched [0]");
                Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero

                if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
                {
                    // get the touch position from the screen touch to world point
                    Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));

                    //touchedPos.x = Mathf.Clamp(touchedPos.x, -1.309437f, 1.315417f);
                    //touchedPos.y = Mathf.Clamp(touchedPos.y, 0.2655097f, 2.57f);

                    // lerp and set the position of the current object to that of the touch, but smoothly over time.
                    transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime * 10);
                }
            }
            if (Input.touchCount >= 2)
            {
            if (bottom.Contains(Input.GetTouch(1).position))
                {
                    Debug.Log("Bot touched [1]");
                    Touch touch = Input.GetTouch(1); // get first touch since touch count is greater than zero

                    if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
                    {
                        // get the touch position from the screen touch to world point
                        Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));

                        //touchedPos.x = Mathf.Clamp(touchedPos.x, -1.309437f, 1.315417f);
                        //touchedPos.y = Mathf.Clamp(touchedPos.y, 0.2655097f, 2.57f);

                        // lerp and set the position of the current object to that of the touch, but smoothly over time.
                        transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime * 10);
                    }
                }
            }
        }
    }
}












/*
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero

            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {

                // get the touch position from the screen touch to world point
                Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));

                touchedPos.x = Mathf.Clamp(touchedPos.x, -1.309437f, 1.315417f);
                touchedPos.y = Mathf.Clamp(touchedPos.y, -2.57f, -0.254f);

                // lerp and set the position of the current object to that of the touch, but smoothly over time.
                transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime *10);
            }
        }
        */
/*
        botY = botRacket.position.y;
        botX = botRacket.position.x;
        v = new Vector2(botX, botY);

        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            isPicked = true;
        }


        if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            isPicked = false;
        }

        //isPicked and touched is not same pos as puck
        if (isPicked == true && Input.GetTouch(0).position != v)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            mousePos.x = Mathf.Clamp(mousePos.x, -1.309437f, 1.315417f);
            mousePos.y = Mathf.Clamp(mousePos.y, -2.57f, -0.254f);
            transform.position = mousePos;
        }
        else if (isPicked == true)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            mousePos.x = Mathf.Clamp(mousePos.x, -1.309437f, 1.315417f);
            mousePos.y = Mathf.Clamp(mousePos.y, -2.57f, -0.254f);
            transform.position = mousePos;
        }
        */
