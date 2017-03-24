using System;
using UnityEngine;

public class Vector
{
	public static Vector3 create (float x, float y)
	{
		return new Vector3 (x, 0.0f, y);
	}
}
