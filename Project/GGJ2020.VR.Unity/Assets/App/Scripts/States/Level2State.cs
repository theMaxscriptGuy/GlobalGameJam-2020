using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2State : BaseState
{

    public static Level2State Instance;
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Level 1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnEnter()
    {
        base.OnEnter();
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}
