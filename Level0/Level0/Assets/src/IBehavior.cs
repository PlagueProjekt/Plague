using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBehavior
{
    States getState();

    // TODO: think about params
    void executeBehavior();
    States calcNewState();
	
}
