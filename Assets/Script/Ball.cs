using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    public float speed;
    public Text BotScoreText;
    public Text TopScoreText;
    private int BotScore;
    private int TopScore;
    public float random;
    public GameObject win;
    public GameObject leave;
    public GameObject lose;
    public Transform Puck;
    public Rigidbody2D rigid;
    public AudioSource PuckHit1, PuckHit2, PuckHit3, PuckHit4, PuckHit5;
    public AudioSource Victory, Defeat;
    public AudioSource PuckGoal;

    void Start()
    {

        win.gameObject.SetActive(false);
        lose.gameObject.SetActive(false);
        leave.gameObject.SetActive(false);

        //random = Random.Range(0, 100);

        //// Initial Velocity
        //if (random < 50)
        //{
        //    GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        //    Debug.Log("Up: " + random);
        //}
        //else if (random > 50)
        //{
        //    GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
        //    Debug.Log("Down: " + random);
        //}
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketHeight)
    {
        // ascii art:
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket
        return (ballPos.y - racketPos.y) / racketHeight;
    }
    float hitFactor2(Vector2 ballPos, Vector2 racketPos,
            float racketHeight)
    {
        // ascii art:
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket
        return (ballPos.x - racketPos.x) / racketHeight;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //HIT LEFT WALL
        if (col.gameObject.name == "Left Wall" || col.gameObject.name == "Right Wall" || col.gameObject.name == "Top Wall [L]" || col.gameObject.name == "Top Wall [R]" || col.gameObject.name == "Bot Wall [L]" || col.gameObject.name == "Bot Wall [R]")
        {
            //Play Puck Hit SFX
            random = Random.Range(0, 100);
            if (random >= 0 && random <= 20)
            {
                PuckHit1.Play();
            }
            else if (random >= 21 && random <= 40)
            {
                PuckHit2.Play();
            }
            else if (random >= 41 && random <= 60)
            {
                PuckHit3.Play();
            }
            else if (random >= 61 && random <= 80)
            {
                PuckHit4.Play();
            }
            else if (random >= 81 && random <= 100)
            {
                PuckHit5.Play();
            }
        }

        // Note: 'col' holds the collision information. If the
        // Ball collided with a racket, then:
        //   col.gameObject is the racket
        //   col.transform.position is the racket's position
        //   col.collider is the racket's collider


        // Hit the bot Racket?
        if (col.gameObject.name == "Bot Racket")
        {
            //Play Puck Hit SFX
            random = Random.Range(0, 100);
            if (random >= 0 && random <= 20)
            {
                PuckHit1.Play();
            }
            else if (random >= 21 && random <= 40)
            {
                PuckHit2.Play();
            }
            else if (random >= 41 && random <= 60)
            {
                PuckHit3.Play();
            }
            else if (random >= 61 && random <= 80)
            {
                PuckHit4.Play();
            }
            else if (random >= 81 && random <= 100)
            {
                PuckHit5.Play();
            }

            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            float x = hitFactor2(transform.position,
                    col.transform.position,
                    col.collider.bounds.size.x);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(x, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // Hit the top Racket?
        if (col.gameObject.name == "Top Racket")
        {
            //Play Puck Hit SFX
            random = Random.Range(0, 100);
            if (random >= 0 && random <= 20)
            { 
                PuckHit1.Play();
            }
            else if (random >= 21 && random <= 40)
            {
                PuckHit2.Play();
            }
            else if (random >= 41 && random <= 60)
            {
                PuckHit3.Play();
            }
            else if (random >= 61 && random <= 80)
            {
                PuckHit4.Play();
            }
            else if (random >= 81 && random <= 100)
            {
                PuckHit5.Play();
            }

            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);
            // Calculate hit Factor
            float x = hitFactor2(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.x);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(x, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        //Score for Bot/Player2
        if (col.gameObject.name == "Bot Goal")
        {
            TopScore++;
            TopScoreText.text = "" + TopScore;
            PuckGoal.Play();
            random = Random.Range(0, 100);
            if (random >= 0 && random <= 33)
            {
                Puck.position = new Vector3(-1, -1, 0);
                rigid.velocity = Vector2.zero;
            }
            if (random >= 34 && random <= 66)
            {
                Puck.position = new Vector3(0, -1, 0);
                rigid.velocity = Vector2.zero;
            }
            if (random >= 67 && random <= 100)
            {
                Puck.position = new Vector3(-1, -1, 0);
                rigid.velocity = Vector2.zero;
            }
        }
        //Score for Player1
        if (col.gameObject.name == "Top Goal")
        {
            PuckGoal.Play();
            BotScore++;
            BotScoreText.text = "" + BotScore;

            random = Random.Range(0, 100);
            if (random >= 0 && random <= 33){
                Puck.position = new Vector3(1, 1, 0);
                rigid.velocity = Vector2.zero;
            }
            if (random >= 34 && random <= 66)
            {
                Puck.position = new Vector3(0, 1, 0);
                rigid.velocity = Vector2.zero;
            }
            if (random >= 67 && random <= 100)
            {
                Puck.position = new Vector3(-1, 1, 0);
                rigid.velocity = Vector2.zero;
            }

        }


        //Defeat for Player1
        if (TopScore == 7)
        {
            Time.timeScale = 0;
            lose.gameObject.SetActive(true);
            leave.gameObject.SetActive(true);
            Defeat.Play();


        }
        //Victory for Player1
        if (BotScore == 7)
        {
            Time.timeScale = 0;
            win.gameObject.SetActive(true);
            leave.gameObject.SetActive(true);
            Victory.Play();
        }

    }

}