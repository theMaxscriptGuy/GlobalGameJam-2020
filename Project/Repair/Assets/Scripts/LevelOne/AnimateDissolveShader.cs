using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateDissolveShader : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.SetFloat("_DissolveAmount", Mathf.PingPong(Time.time * speed, 0.5f));
    }
}
