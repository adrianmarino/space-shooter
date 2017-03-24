using System;
using UnityEngine;

public class InputUtils
{

	public static float nextHorizontalMovement ()
	{
		return Input.GetAxis ("Horizontal");
	}

	public static float nextVerticalMovement ()
	{
		return Input.GetAxis ("Vertical");
	}

	private InputUtils ()
	{
	}
}

