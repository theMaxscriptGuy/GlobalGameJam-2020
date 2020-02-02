using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LitUp : MonoBehaviour
{
    [SerializeField]
    private List<Light> m_lights;

    [SerializeField]
    private float m_intensity;

    [SerializeField]
    private float m_speed;

    private bool switchOnLights = false;
    // Start is called before the first frame update
    void Start()
    {
        //m_lights = (GetComponentsInChildren<Light>()).ToList().Where(o=>o.type == LightType.Point).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            switchOnLights = true;
        }
        if(switchOnLights)
        {
            if(m_lights.Count == 0)
            {
                switchOnLights = false;
            }
            foreach (Light l in m_lights)
            {
                LightsOn(l);
            }
        }

    }
    public void LightsOn(Light l)
    {
        if (l.intensity < m_intensity)
        {
            l.gameObject.SetActive(true);
            l.intensity += (Time.deltaTime * m_speed);
            return;
        }
        m_lights.Remove(l);
    }
}
