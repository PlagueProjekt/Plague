﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public List<Level> levels = new List<Level>();


	// Use this for initialization
	void Start () {
        levels.Add(new Tutorial());
	}
	

}
