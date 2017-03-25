using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	[System.Serializable]
	public class VerstionRotationMovement
	{
		public void Update (GameElement element)
		{
			element.Rotate (Quaternion.Euler (0.0f, 0.0f, element.Velocity ().x * -Tilt));
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public float Tilt {
			get { return tilt; }
			set { tilt = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private float tilt;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public VerstionRotationMovement ()
		{
			Tilt = 4;
		}
	}
}
