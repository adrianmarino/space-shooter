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
		// Public Methods
		//-----------------------------------------------------------------------------

		public void instanciate (Transform transform)
		{
			Instantiate (gameObject, transform.position, transform.rotation);
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