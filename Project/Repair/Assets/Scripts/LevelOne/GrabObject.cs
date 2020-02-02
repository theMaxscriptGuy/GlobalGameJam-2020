using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    [SerializeField]
    private GameObject hand;
    private GameObject currentSelection = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSelection == null)
            return;
        currentSelection.transform.position = hand.transform.position + (Camera.main.transform.forward * 2f);
    }

    public void OnGrabObject(GameObject go)
    {
        if (currentSelection != null)
            return;

        currentSelection = go;
    }

    public void OnPointerRaycast(GameObject go)
    {
        if (currentSelection == null)
            return;

        Piece p = currentSelection.GetComponent<Piece>();
        if (!p)
            return;
        PlaceHolder ph = go.GetComponent<PlaceHolder>();
        if (!ph)
            return;
        if (p.id == ph.m_id)
        {
            currentSelection = null;
            //p.transform.parent = ph.transform;
            p.transform.position = ph.transform.position;
            //p.transform.rotation = Quaternion.identity;
        }
            
    }
}
