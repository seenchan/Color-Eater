using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.down * GameManager.Instance.ballSpeed);
    }
}
