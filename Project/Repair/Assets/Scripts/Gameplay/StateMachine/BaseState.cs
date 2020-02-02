using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState : MonoBehaviour
{
    public GameObject[] enableObjects;
    public GameObject[] disableObjects;

   
    public void Start()
    {
        if (enableObjects != null)
            enableObjects.EnableAll(false);

   }
    public virtual void OnEnter()
    {
        Debug.Log($"### Entering State {gameObject.name}");
        enableObjects.EnableAll(true);
        disableObjects.EnableAll(false);
    }

    public virtual void OnExit()
    {
        Debug.Log($"### Exiting State {gameObject.name}");
        enableObjects.EnableAll(false);
        disableObjects.EnableAll(true);
    }

}
