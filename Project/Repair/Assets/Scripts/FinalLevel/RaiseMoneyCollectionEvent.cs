using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RaiseMoneyCollectionEvent : MonoBehaviour
{
	public static Action collectMoney;
	private void OnTriggerStay(Collider other)
	{
		collectMoney?.Invoke();
	}
}
