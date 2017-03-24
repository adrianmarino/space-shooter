using UnityEngine;
using System.Collections;
using UnityEngine;
using System;

public class GameObjectUtils
{
	//-----------------------------------------------------------------------------
	// Public Methods
	//-----------------------------------------------------------------------------

	public static bool hasName (GameObject obj, string name)
	{
		return originalName (obj) == name;
	}

	public static string originalName (GameObject obj)
	{
		return obj.name.Replace ("(Clone)", "");
	}

	//-----------------------------------------------------------------------------
	// Constructors
	//-----------------------------------------------------------------------------

	private GameObjectUtils ()
	{
	}
}

