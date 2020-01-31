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
        enableObjects.EnableAll(true);
        disableObjects.EnableAll(false);
    }

    public virtual void OnExit()
    {
        enableObjects.EnableAll(false);
        disableObjects.EnableAll(true);
    }

}
