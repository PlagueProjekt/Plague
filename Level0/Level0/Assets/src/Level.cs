using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public abstract class Level : MonoBehaviour {

    public GameFigure player;
    public GameObject playerobject;
    public List<GameObject> figures = new List<GameObject>();
    public Dictionary<Predicate<GameObject>, string> goals = new Dictionary<Predicate<GameObject>, string>();
    public GameObject target;

	// Use this for initialization
	void Start ()
    {
        InitializeWinConditions();
    }

    public void GoalMet(string nextLevel)
    {       
        SceneManager.LoadScene(nextLevel);
    }

	// Update is called once per frame
	void FixedUpdate ()
    {
        foreach (Predicate<GameObject> condition in goals.Keys)
        {
            if (condition.Invoke(target))
            {
                GoalMet(goals[condition]);
            }
        }
	}
    public abstract void InitializeWinConditions();
}
