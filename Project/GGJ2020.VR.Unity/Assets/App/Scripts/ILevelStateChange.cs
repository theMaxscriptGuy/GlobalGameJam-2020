using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface ILevelStateChange
{
    UnityEvent OnLevelComplete { get; set; }
     
}
