using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectExtensions
{
    public static void EnableAll(this GameObject[] gameObjects, bool flag)
    {
        foreach (GameObject go in gameObjects)
        {
            Debug.Log($" Object:  {go.name} {(flag ? "Enabled":"Disabled")}");
            go.SetActive(flag);
        }
    }
}
