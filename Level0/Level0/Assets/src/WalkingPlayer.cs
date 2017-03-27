using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingPlayer : MonoBehaviour , IBehavior {

    public GameFigure gf;


    public States calcNewState()
    {
        return States.Attacking;
    }

    public void executeBehavior()
    {
        
    }

    public States getState()
    {
        return States.Walking;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
