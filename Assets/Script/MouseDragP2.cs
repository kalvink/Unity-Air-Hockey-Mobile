using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragP2 : MonoBehaviour
{
 //   public bool isPicked;
 //   public float topX, topY;
 //   public Vector2 v;
    public Transform topRacket;
   // public bool isInput0;
    public Rect top;


    //    void Update()
    //    {
    //        if (Input.GetMouseButtonUp(0))
    //        {

    //            isPicked = false;

    //        }
    //        if (isPicked == true)
    //        {
    //            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //            mousePos.x = Mathf.Clamp(mousePos.x, -1.309437f, 1.315417f);
    //            mousePos.y = Mathf.Clamp(mousePos.y, 0.2655097f, 2.57f);
    //            transform.position = mousePos;
    //        }
    //    }
    //    void OnMouseDown()
    //    {

    //        isPicked = true;

    //    }
    //}
    void Start()
    {
        top = new Rect(0, 960, Screen.width, Screen.height/2);
    }

    void Update()
    {
        if (Input.touchCount >= 1)
        {
            if (top.Contains(Input.GetTouch(0).position)) //&& top.Contains(topRacket.position))
            {
                Debug.Log("Top touched [0]");

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
            if (top.Contains(Input.GetTouch(1).position))// && top.Contains(topRacket.position))
                {
                    Debug.Log("Top touched [1]");

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
        topY = topRacket.position.y;
        topX = topRacket.position.x;
        v = new Vector2(topX, topY);

        //if (Input.GetTouch(0).phase == TouchPhase.Began)
        //{
        //    isInput0 = true;
        //}
        //else {

        //    isInput0 = false;
        //}
        
        if (Input.GetTouch(1).phase == TouchPhase.Began) //&& Input.GetTouch(1).position == v)
        {
            isPicked = true;
        }


        if (Input.GetTouch(1).phase == TouchPhase.Ended)
        {
            isPicked = false;
        }

        if (isPicked == true)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.GetTouch(1).position);
            mousePos.x = Mathf.Clamp(mousePos.x, -1.309437f, 1.315417f);
            mousePos.y = Mathf.Clamp(mousePos.y, 0.2655097f, 2.57f);
            transform.position = mousePos;
        }


    */



