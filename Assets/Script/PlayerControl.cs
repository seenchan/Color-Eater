using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public LayerMask hitLayers;
    public GameObject playerSprite;

    private Animator anim;
    private Collider coll;

    // Use this for initialization
    void Start () {
        anim = playerSprite.gameObject.GetComponent<Animator>();
        coll = gameObject.GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        ControlType1();
    }

    void ControlType1()
    {
        if (Input.GetMouseButton(0))
        {
            GameManager.Instance.mouthOpen = true;
            coll.isTrigger = true;
            anim.SetInteger("MouthStatus",1);
        }
        else
        {
            GameManager.Instance.mouthOpen = false;
            coll.isTrigger = false;
            anim.SetInteger("MouthStatus", 0);
        }
    }
    void ControlType2()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        this.transform.Translate(new Vector3(10,10,0));
    }

}
