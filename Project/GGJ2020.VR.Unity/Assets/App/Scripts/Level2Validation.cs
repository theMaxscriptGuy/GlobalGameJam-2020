using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Level2Validation : MonoBehaviour
{
    public UnityEvent OnLevelComplete;
    public GameObject lifeLine;


    public Material lifeMaterial;
  
    // Start is called before the first frame update
    void Start()
    {
        lifeMaterial = lifeLine.gameObject.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

        var life = lifeMaterial.GetFloat("_FillAmount");
        if (life <= 0)
        {
            OnLevelComplete?.Invoke();
            AppManager.Instance.SwitchState(AppStartedState.Instance);
        }
    }
}
