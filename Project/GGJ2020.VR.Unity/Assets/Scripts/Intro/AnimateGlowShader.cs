using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateGlowShader : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;

    private Material mat;
    private float val;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        val = Mathf.PingPong(Time.time * speed, 0.5f);
        mat.SetFloat("_DotEmissive", val);
        mat.SetFloat("_FresnelPower", -val * 3f);
    }
}
