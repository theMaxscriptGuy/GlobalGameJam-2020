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

    private void OnTriggerEnter(Collider other)
    {
        if (!switchOnLights)
        {
            switchOnLights = true;
            foreach (Light l in m_lights)
                StartCoroutine(SwitchOnLight(l));
        }
    }

    IEnumerator SwitchOnLight(Light l)
    {
        while(l.intensity < m_intensity)
        {
            l.intensity += (Time.deltaTime * m_speed);
            yield return new WaitForEndOfFrame();
        }
    }
}
