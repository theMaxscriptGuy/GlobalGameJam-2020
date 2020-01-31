using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManger : Singleton<GameManger>
{
    [HideInInspector]
    public BaseState currentAppState;
    private BaseState previousState;

    void Awake()
    {
        
    }

    // Use this for initialization
    void Start()
    {
        previousState = null;
    }

    void SwitchState(BaseState newState)
    {
        if (previousState != null)
        {
            previousState.OnExit();
        }
        previousState = currentAppState;
        currentAppState = newState;
        currentAppState.OnEnter();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
