using UnityEngine;

namespace SpaceShooter
{
	public class Asteroid :  Core.GameElement
	{
		//--------------------------------------------------------------
		// Engine Events
		//--------------------------------------------------------------

		void Start ()
		{
			SetVerticalRotation ();
			ApplyVelocity (Speed);
		}

		//--------------------------------------------------------------
		// Public Static Methods
		//--------------------------------------------------------------
	
		public static void DestroyAll ()
		{
			Core.GameElement.DestroyAllByTag ("Asteroid");
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private void SetVerticalRotation ()
		{
			GetRigidbody ().angularVelocity = Random.insideUnitSphere * tumble;
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public float Tumble {
			get { return tumble; }
			set { tumble = value; }
		}

		public float Speed {
			get { return speed; }
			set {
				speed = value;
				ApplyVelocity (speed);
			}
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private float speed;

		[SerializeField]
		private float tumble;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public Asteroid ()
		{
			tumble = 3;
			speed = -4;
		}
	}
}