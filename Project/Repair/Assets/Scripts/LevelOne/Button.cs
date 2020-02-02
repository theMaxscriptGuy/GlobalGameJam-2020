using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour
{
    [SerializeField] private Transform startPos = null;
    [SerializeField] private float speed = 0;
    [SerializeField] private float distance;
    private Vector3 endPos = Vector3.zero;
    private Coroutine hoverAnim;

    private void Start()
    {
        
    }

    public void OnMouseEnter()
    {
        hoverAnim = StartCoroutine(HoverAnimation());
    }

    public void OnMouseExit()
    {
        StopCoroutine(hoverAnim);
        transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z - distance);
    }

    public void OnMouseDown()
    {
        Debug.LogError(transform.name + "PRESSED");
    }

    private IEnumerator HoverAnimation()
    {
        
        Debug.Log(startPos.position);
        endPos = new Vector3(startPos.position.x, startPos.position.y, startPos.position.z + distance);
        float startTime = Time.time;
        float journeyLength = Vector3.Distance(startPos.position, endPos);

        float fractionOfJourney = 0;
        while (fractionOfJourney < 1)
        {
            float distCovered = (Time.time - startTime) * speed;
            fractionOfJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startPos.position, endPos, fractionOfJourney);
            yield return new WaitForFixedUpdate();
        }
    }
}
