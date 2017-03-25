using UnityEngine;

namespace SpaceShooter
{
	public class LaserShot : Core.GameElement
	{
		//-----------------------------------------------------------------------------
		// Engine Events
		//-----------------------------------------------------------------------------

		void Start ()
		{
			ApplyVelocity (Speed);
		}

		//-----------------------------------------------------------------------------
		// Public Methods
		//-----------------------------------------------------------------------------

		public void Instanciate (Transform transform)
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