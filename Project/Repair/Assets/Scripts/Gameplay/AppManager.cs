using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : GameManger    
{
    public BaseState startState;
    // Start is called before the first frame update
    void Start()
    {
        SwitchState(startState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
