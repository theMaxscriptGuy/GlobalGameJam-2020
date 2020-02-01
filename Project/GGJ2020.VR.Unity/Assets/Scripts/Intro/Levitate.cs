using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitate : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;
    [SerializeField]
    private Vector2 limits;
    private Vector3 originalTransform = Vector3.zero;
    private float yVal = 0f;
    private Vector3 rotationAxis = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yVal = Mathf.Lerp(limits.x, limits.y, Mathf.PingPong(Time.time, 1f));
        originalTransform.y = yVal * Time.deltaTime * speed;
        transform.position += originalTransform;
        rotationAxis.x = Random.Range(0f, 1f);
        //rotationAxis.y = Random.Range(0f, 1f);
        rotationAxis.z = Random.Range(0f, -1f);
        transform.Rotate(rotationAxis, Time.deltaTime + speed);
    }
}
