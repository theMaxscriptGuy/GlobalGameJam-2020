using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifeline : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Material mat;
    private float initialVal;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        initialVal = mat.GetFloat("_FillAmount");
    }

    // Update is called once per frame
    void Update()
    {
        mat.SetFloat("_FillAmount", initialVal - (Time.deltaTime * speed));
        initialVal = mat.GetFloat("_FillAmount");
    }
}
