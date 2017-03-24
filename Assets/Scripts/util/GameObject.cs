using UnityEngine;
using System.Collections;
using System;

namespace Util
{
	public class GameObject
	{
		//-----------------------------------------------------------------------------
		// Public Methods
		//-----------------------------------------------------------------------------

		public static bool hasName (UnityEngine.GameObject obj, string name)
		{
			return originalName (obj) == name;
		}

		public static string originalName (UnityEngine.GameObject obj)
		{
			return obj.name.Replace ("(Clone)", "");
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		private GameObject ()
		{
		}
	}
}
