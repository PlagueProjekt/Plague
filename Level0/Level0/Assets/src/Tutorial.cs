using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : Level {

    public float levelend;

    public override void InitializeWinConditions()
    {
        Predicate<GameObject> EndReached = new Predicate<GameObject>(playerobject => playerobject.transform.position.x >= levelend);
        goals.Add(EndReached, "Level1");
        Predicate<GameObject> Dead = new Predicate<GameObject>(playerobject => playerobject.transform.position.y < -5 );
        goals.Add(Dead, "GameOverScreen");
    }
}
