/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour {
    public GameObject asd;

    public Sprite[] puckSprites;

    void Awake()
    {
        // load all frames in fruitsSprites array
        puckSprites = Resources.LoadAll<Sprite>("pucks");
    }

   public void Start()
    {
        sprites = new SpriteCollection("Spritesheet");
        GetComponent<SpriteRenderer>().sprite = sprites.GetSprite("Sprite1");

        puckSprites = Resources.LoadAll<Sprite>("pucks");

        // create the object
        GameObject puck = new GameObject();
        // add a "SpriteRenderer" component to the newly created object
        puck.AddComponent<SpriteRenderer>();
        // assign "fruit_9" sprite to it
        puck.GetComponent<SpriteRenderer>().sprite = puckSprites[0];
        // to assign the 5th frame
        puck.GetComponent<SpriteRenderer>().sprite = puckSprites[1];
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void ChangeSprites(int puckToChangeTo) {
        asd.GetComponent<SpriteRenderer>().sprite = puckSprites[puckToChangeTo];

    }

}
*/