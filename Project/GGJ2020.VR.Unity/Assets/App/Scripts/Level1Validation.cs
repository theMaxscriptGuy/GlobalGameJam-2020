using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Level1Validation : MonoBehaviour
{
    public UnityEvent OnLevelComplete;

    public int totalPieces = 6;
    public int piecesCollected = 0;
    public void OnPieceAttached()
    {
        piecesCollected++;
        Debug.Log($"{piecesCollected} / {totalPieces} Collected!");

        if (piecesCollected >= totalPieces)
        {
            Debug.Log($"All Pieces Collected!");

            OnLevelComplete?.Invoke();
            AppManager.Instance.SwitchState(AppStartedState.Instance);
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
