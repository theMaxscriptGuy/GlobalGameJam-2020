using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    [SerializeField]
    private GameObject hand;

    [SerializeField]
    private GameObject focus;

    private LineRenderer m_lineRenderer;
    private List<Vector3> positions = new List<Vector3>() { Vector3.zero, Vector3.zero};
    // Start is called before the first frame update
    void Start()
    {
        m_lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Ray r = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        //RaycastHit hit;
        //if(Physics.Raycast(r, out hit))
        //{
        //    Debug.Log($"Object Hit {hit.collider.name}");
        //    positions[0] = hand.transform.position;
        //    positions[1] = hit.transform.position;
        //}
        //else
        //{

        //}

        positions[1] = Camera.main.transform.forward * 5f;
        focus.transform.position = positions[1];
        focus.transform.LookAt(Camera.main.transform.position);
    }
}
