using System;
using UnityEngine;

namespace Util
{
	public class Input
	{
		public static Vector2 nextDirection ()
		{
			return new Vector2 (nextXDirection (), nextYDirection ());
		}

		public static float nextXDirection ()
		{
			return UnityEngine.Input.GetAxis ("Horizontal");
		}

		public static float nextYDirection ()
		{
			return UnityEngine.Input.GetAxis ("Vertical");
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		private Input ()
		{
		}
	}
}

