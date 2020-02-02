using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private int m_timeThreshold;
    [SerializeField]
    private float m_speed;
    private float m_currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_currentTime += Time.deltaTime + m_speed;
        if(m_currentTime > m_timeThreshold)
        {
            GameObject.DestroyImmediate(gameObject);
        }
    }
}
