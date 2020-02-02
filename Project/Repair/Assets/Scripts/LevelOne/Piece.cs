using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public int id;

    public void DisableLights()
    {
        var lights = GetComponentsInChildren<Light>();
        foreach (var light in lights)
        {

            light.enabled = false;
        }
    }
}
