using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHolder : MonoBehaviour
{
    [SerializeField]
    private int m_id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("TRIGGER");
        Piece p = other.transform.GetComponent<Piece>();
        if (!p)
            return;
        if (p.id == m_id)
        {
            //place the tranform here:
            p.transform.position = transform.position;
        }
    }
}
