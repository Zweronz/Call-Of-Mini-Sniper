using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
	private void Start()
	{
		DontDestroyOnLoad(gameObject);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.F1))
		{
			Screen.lockCursor = !Screen.lockCursor;
		}
	}
}
