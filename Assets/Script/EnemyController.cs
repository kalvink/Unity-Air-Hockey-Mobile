using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    //Speed of the enemy
    public float speed = 1.5F;

    //the ball
    Transform ball;

    //the ball's rigidbody 2D
    Rigidbody2D ballRig2D;

    //bounds of enemy
    public float rightBound = 1.29F;
    public float leftBound = -1.29F;
    public float topBound = 2.560156F;
    public float botBound = 0.2655641F;
    //public float random;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
             //   random = Random.Range(0, 100);

        //finding the ball
        ball = GameObject.FindGameObjectWithTag("Ball").transform;

        //setting the ball's rigidbody to a variable
        ballRig2D = ball.GetComponent<Rigidbody2D>();

        //Checking y direction of the bal
        // if puck is moving up
        //1 = up
        //0 = nothing
        //-1 = down

        if (ballRig2D.velocity.y > 0)
        {
            //checking x direction of the ball 
            //1 = right
            //0 = nothing
            //-1 = left
            //X
            if (ball.position.x < this.transform.position.x)
            {
                //move paddle down if ball lower than paddle
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            else if (ball.position.x > this.transform.position.x)
            {
                //move paddle up if ball high than paddle
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            //Y
            //if ball is above paddle
            if (ball.position.y > this.transform.position.y)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            //if ball is under paddle
            else if (ball.position.y < this.transform.position.y)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);

            }
        }

        //if ball scores and velocity is 0 (stopped moving) 
        if (ballRig2D.velocity.y == 0)
        {
            //X
            if (ball.position.x < this.transform.position.x)
            {
                //move paddle down if ball lower than paddle
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            else if (ball.position.x > this.transform.position.x)
            {
                //move paddle up if ball high than paddle
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            //Y
            //if ball is above paddle
            if (ball.position.y > this.transform.position.y)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            //if ball is under paddle
            else if (ball.position.y < this.transform.position.y)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);

            }
        }
        //if ball scores and velocity is 0 (stopped moving) 
        if (ballRig2D.velocity.x == 0)
        {
            //X
            if (ball.position.x < this.transform.position.x)
            {
                //move paddle down if ball lower than paddle
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            else if (ball.position.x > this.transform.position.x)
            {
                //move paddle up if ball high than paddle
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            //Y
            //if ball is above paddle
            if (ball.position.y > this.transform.position.y)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            //if ball is under paddle
            else if (ball.position.y < this.transform.position.y)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);

            }
        }


        //if (random > 0 && random < 25)
        //{
        //    Debug.Log("Left" + random);
        //    transform.Translate(Vector3.left * speed * Time.deltaTime);

        //}
        //else if (random > 25 && random < 50)
        //{
        //    Debug.Log("Up" + random);
        //    transform.Translate(Vector3.up * speed * Time.deltaTime);
        //}
        //else if (random > 50 && random < 75)
        //{
        //    Debug.Log("Right" + random);

        //    transform.Translate(Vector3.right * speed * Time.deltaTime);
        //}
        //else if (random > 75 && random < 100)
        //{
        //    Debug.Log("Down" + random);

        //    transform.Translate(Vector3.down * speed * Time.deltaTime);
        //}
















        //set bounds of enemy
        //x boundary
        if (transform.position.x > rightBound)
        {

            transform.position = new Vector2(rightBound, transform.position.y);
        }
        else if (transform.position.x < leftBound)
        {
            transform.position = new Vector2(leftBound, transform.position.y);
        }

        //y boundary
        if (transform.position.x > rightBound)
        {

            transform.position = new Vector2(rightBound, transform.position.y);
        }
        else if (transform.position.x < leftBound)
        {
            transform.position = new Vector2(leftBound, transform.position.y);
        }
    }
}