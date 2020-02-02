using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickInput : MonoBehaviour
{
    Ray r;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        r = new Ray();
        hit = new RaycastHit();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.JoystickButton0))
        {
            //A
            Debug.Log("KeyCode.JoystickButton0");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton1))
        {
            //B
            Debug.Log("KeyCode.JoystickButton1");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton2))
        {
            //X
            Debug.Log("KeyCode.JoystickButton2");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton3))
        {
            //Y
            Debug.Log("KeyCode.JoystickButton3");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton4))
        {
            //LB
            Debug.Log("KeyCode.JoystickButton4");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton5))
        {
            //RB
            r.origin = Camera.main.transform.position;
            r.direction = Camera.main.transform.forward;
            if(Physics.Raycast(r, out hit))
            {
                ExecuteEvents.Execute(hit.collider.gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
            }
            //Debug.Log("KeyCode.JoystickButton5");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton6))
        {
            //left menu
            Debug.Log("KeyCode.JoystickButton6");
        }


        if (Input.GetKeyUp(KeyCode.JoystickButton7))
        {
            //right menu
            Debug.Log("KeyCode.JoystickButton7");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton8))
        {
            //LStick
            Debug.Log("KeyCode.JoystickButton8");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton9))
        {
            //RStick
            Debug.Log("KeyCode.JoystickButton9");
        }


        if (Input.GetKeyUp(KeyCode.JoystickButton10))
        {
            Debug.Log("KeyCode.JoystickButton10");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton11))
        {
            Debug.Log("KeyCode.JoystickButton11");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton12))
        {
            Debug.Log("KeyCode.JoystickButton12");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton13))
        {
            Debug.Log("KeyCode.JoystickButton13");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton14))
        {
            Debug.Log("KeyCode.JoystickButton14");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton15))
        {
            Debug.Log("KeyCode.JoystickButton15");
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton16))
        {
            Debug.Log("KeyCode.JoystickButton16");
        }
    }
}
