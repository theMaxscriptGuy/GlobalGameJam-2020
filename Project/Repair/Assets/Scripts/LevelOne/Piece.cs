using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public int id;

    private Vector3 offset = Vector3.zero;
    private Vector3 screenPoint = Vector3.zero;
    private Vector3 curScreenPoint = Vector3.zero;
    private Vector3 curPosition = Vector3.zero;
    
    private void OnMouseDown()
    {
        Debug.Log(transform.name + "Touched");
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,screenPoint.z));
    }

    private void OnMouseDrag()
    {
        Debug.Log(transform.name + "Dragged");
        // curScreenPoint = new Vector3(Input.mousePosition.x,Input.mousePosition.y,screenPoint.z);
        curScreenPoint = new Vector3(Input.mousePosition.x,transform.localPosition.y,Input.mousePosition.z);
        curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);// + offset;
        transform.position = curPosition;
    }

}
