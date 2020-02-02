using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLevelSelected(int level)
    {
        Debug.Log($"Level Selected : {level}");
        switch (level)
        {
            case 1:
                AppManager.Instance.SwitchState(Level1State.Instance);
                break;
            case 2:
                AppManager.Instance.SwitchState(Level2State.Instance);
                break;
            default:
                break;
        }
       
    }
}
