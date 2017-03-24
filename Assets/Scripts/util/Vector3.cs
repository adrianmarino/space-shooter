using System;

namespace Util
{
	public class Vector3
	{
		public static UnityEngine.Vector3 create (float x, float y)
		{
			return new UnityEngine.Vector3 (x, 0.0f, y);
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		private Vector3 ()
		{
		}
	}
}