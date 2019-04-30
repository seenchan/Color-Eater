using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerColor : MonoBehaviour {

    public GameObject playerTag;
    public GameObject playerSprite;

    private SpriteRenderer spriteColor;
    private Color colorWheel;

    // Use this for initialization
    void Start () {
        spriteColor = playerSprite.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        CheckTag();
        spriteColor.color = colorWheel;
	}

    void CheckTag()
    {
        if(playerTag.tag == "Green")
        {
            colorWheel = Color.green;
        }
        else if (playerTag.tag == "Blue")
        {
            colorWheel = Color.blue;
        }
        else if (playerTag.tag == "Red")
        {
            colorWheel = Color.red;
        }
        else if (playerTag.tag == "Yellow")
        {
            colorWheel = Color.yellow;
        }
        else if (playerTag.tag == "Purple")
        {
            colorWheel = Color.magenta;
        }
        else if (playerTag.tag == "Orange")
        {
            colorWheel = new Color32(255, 106, 0, 255);
        }
    }
}
