using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFigure : MonoBehaviour, IDestroyable {

    public List<States> states;
    public List<IBehavior> behaviors;
    public float life;
    public float maxvelocity;
    public float maxjumpheigth;
    public Rigidbody2D rb;
    public BoxCollider2D bc;
    public Animator anim;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Machine();       
	}
    
    public void Machine()
    {
        foreach (IBehavior behavior in behaviors)
        {
            if (states.Contains(behavior.getState())) {
                behavior.executeBehavior();
                states.Remove(behavior.getState());
                states.Add(behavior.calcNewState());
            }
        }
    }

    public float Damage()
    {
        return 0;
    }

    public float Life()
    {
        return 0;
    }

    public void Destruction() {

    }
    

}
