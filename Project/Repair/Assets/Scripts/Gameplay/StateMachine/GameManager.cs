using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManger : Singleton<GameManger>
{
    
    public BaseState currentAppState;
    private BaseState previousState;

    void Awake()
    {

    }

    // Use this for initialization
    void Start()
    {
      //  previousState = null;
    }

    public void SwitchState(BaseState newState)
    {
        newState.OnEnter();
        if (currentAppState != null)
        {
            currentAppState.OnExit();
        }
        previousState = currentAppState;
        currentAppState = newState;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
