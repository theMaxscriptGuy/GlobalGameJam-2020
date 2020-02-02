using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseSocializeEvent : MonoBehaviour
{
	public static Action socialize;
	private void OnTriggerStay(Collider other)
	{
		socialize?.Invoke();
	}
}
