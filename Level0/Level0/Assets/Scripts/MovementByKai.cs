using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementByKai : MonoBehaviour {

    public Rigidbody2D rigid;
    public float jumpVel;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButton("Jump"))
        {
            rigid.velocity = new Vector2(0, jumpVel);
        }
    }
}
