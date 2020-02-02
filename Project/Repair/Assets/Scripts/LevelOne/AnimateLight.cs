using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateLight : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;
    private Light mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        mat.intensity = Mathf.PingPong(Time.time, 1f) * 10;
    }
}
