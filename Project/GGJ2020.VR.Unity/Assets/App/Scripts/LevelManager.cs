using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : Singleton<LevelManager>
{
    public int currentLevel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel(int levelIndex)
    {
        if (levelIndex != 0 && currentLevel != levelIndex)
        {
            Debug.Log($"Loading Level {levelIndex}");
            SceneManager.UnloadSceneAsync(levelIndex);
            SceneManager.LoadSceneAsync(levelIndex, LoadSceneMode.Additive);
            currentLevel = levelIndex;
        }
        else
        {
            Debug.Log($"Can't load level {levelIndex}");
        }
    }
}
