using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseExerciseEvent : MonoBehaviour
{
	public static Action doExercise;
	private void OnTriggerStay(Collider other)
	{
		doExercise?.Invoke();
	}
}
