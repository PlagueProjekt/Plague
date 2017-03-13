using UnityEngine;
using System.Collections;

public class AnimScript : MonoBehaviour {

    //public float swim=0;
    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("run", Input.GetAxis("Horizontal"));
	}
}
