using UnityEngine;

namespace SpaceShooter
{
	public class LaserShot : Core.GameElement
	{
		void Start ()
		{
			applyVelocity (Speed);
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public float Speed {
			get { return speed; }
			set { speed = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private float speed;
	}
}