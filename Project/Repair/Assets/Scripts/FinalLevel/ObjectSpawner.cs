    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;
    [SerializeField]
    private Vector2 limits;
    private Vector3 originalTransform = Vector3.zero;
    private float yVal = 0f;
    private Vector3 rotationAxis = Vector3.zero;

    [SerializeField]
    private GameObject spawnObject;
    [SerializeField]
    private Vector2 limitScale;

    [SerializeField]
    private int timeThreshold = 2;
    private float currentTime = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        yVal = Mathf.Lerp(limits.x, limits.y, Mathf.PingPong(Time.time, 1f));
        originalTransform.z = yVal * Time.deltaTime * speed * 0.5f;
        originalTransform.x = yVal * Time.deltaTime * speed;
        transform.position += originalTransform;
        
        //rotationAxis.x = Random.Range(0f, 1f);
        ////rotationAxis.y = Random.Range(0f, 1f);
        //rotationAxis.z = Random.Range(0f, -1f);
        //transform.Rotate(rotationAxis, Time.deltaTime + speed);

        currentTime += (Time.deltaTime + speed);
        if(currentTime > timeThreshold)
        {
            currentTime = 0;
            GameObject go = GameObject.Instantiate(spawnObject);
            go.transform.position = transform.position;
            var randomVal = Random.Range(limitScale.x, limitScale.y);
            go.transform.localScale = Vector3.one * randomVal;
        }
    }
}
