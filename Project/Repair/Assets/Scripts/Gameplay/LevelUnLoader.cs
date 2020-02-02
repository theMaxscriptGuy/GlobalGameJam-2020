using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnLoader : MonoBehaviour
{
    public int LevelIndex;
    private void OnEnable()
    {
        if (LevelIndex != 0)
        {
            LevelManager.Instance.UnLoadLevel(LevelIndex);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
