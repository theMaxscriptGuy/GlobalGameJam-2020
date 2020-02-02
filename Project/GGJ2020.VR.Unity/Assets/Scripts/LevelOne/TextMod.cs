using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMod : MonoBehaviour
{
    [SerializeField] private float timeModifier = 0f;
    [SerializeField] private float maxDilation = 0f;
    private TextMeshPro tmp;
    void Start()
    {
        tmp = GetComponent<TextMeshPro>();
    }

    private void Update()
    {
        tmp.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, Mathf.PingPong(Time.time * timeModifier,maxDilation));
    }
}
