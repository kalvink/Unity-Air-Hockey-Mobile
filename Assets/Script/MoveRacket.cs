using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float speed = 3;
    public string vertical = "Vertical";
    public string horizontal = "Horizontal";
    public Transform botRacket;
    public Transform topRacket;
    public GameObject line;
    public float botY, botX;
    public float topY, topX;
    public Transform puck;
    public Rigidbody2D puckrigid;
    void Update()
    {
        botY = botRacket.position.y;
        botX = botRacket.position.x;


        if (Input.GetKeyDown(KeyCode.R))
        {
            puck.position = new Vector2(0, 0);
            puckrigid.velocity = Vector2.zero;

        }
    }
    //FixedUpdate() function is called over and over in a fixed time interval 
    void FixedUpdate()
    {
        //Assigning Vertical input to the rackets (W,S, Up,Dwn)
        float v = Input.GetAxisRaw(vertical);
        float h = Input.GetAxisRaw(horizontal);
        //Making rackets move
        GetComponent<Rigidbody2D>().velocity = new Vector2(h, v) * speed;


    }


}
