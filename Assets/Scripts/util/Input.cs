using System;
using UnityEngine;

namespace Util
{
	public class Input
	{
		public static Vector2 NextDirection ()
		{
			return new Vector2 (NextXDirection (), NextYDirection ());
		}

		public static float NextXDirection ()
		{
			return UnityEngine.Input.GetAxis ("Horizontal");
		}

		public static float NextYDirection ()
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

