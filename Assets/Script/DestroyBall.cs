using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBall : MonoBehaviour {

    public string[] colorTag;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {

	}

    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == this.tag)
        {
            Debug.Log("YAAAY!!");
            obj.tag = colorTag[Random.Range(0, 5)];
            Destroy(this.gameObject);
            GameManager.Instance.combo++;
            GameManager.Instance.score+= GameManager.Instance.combo;
            if (GameManager.Instance.combo >= 10)
            {
                GameManager.Instance.health++;
            }
        }
        else if (obj.tag == "Limit")
        {
            Destroy(this.gameObject);
        }
        else if (obj.tag != this.tag)
        {
            Debug.Log("UUUH!!!");
            Destroy(this.gameObject);
            GameManager.Instance.health--;
            GameManager.Instance.combo = 0;
        }
    }
}
