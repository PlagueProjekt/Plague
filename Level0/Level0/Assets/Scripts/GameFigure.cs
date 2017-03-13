using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFigure : MonoBehaviour, IDestroyable {

    public States state;
    public float life;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Machine();
        Act();
	}
    
    public void Machine() {
    }

    public void Act() {
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
