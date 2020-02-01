using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateDissolveShader : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;
    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        mat.SetFloat("_DissolveAmount", Mathf.PingPong(Time.time * speed, 0.5f));
    }
}
