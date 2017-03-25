using UnityEngine;

namespace SpaceShooter
{
	public class LaserWeapon : Core.GameElement
	{
		void Update ()
		{
			if (Input.GetButton (ShotButton) && Time.time > nextShot) {
				nextShot = Time.time + ShotRate;
				LaserShot.instanciate (transform);
			}
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public LaserShot LaserShot {
			get { return laserShot; }
			set { laserShot = value; }
		}

		public float ShotRate {
			get { return shotRate; }
			set { shotRate = value; }
		}

		public string ShotButton {
			get { return shotButton; }
			set { shotButton = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private LaserShot laserShot;

		[SerializeField]
		private float shotRate;

		[SerializeField]
		private string shotButton;

		[SerializeField]
		private float nextShot;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public LaserWeapon ()
		{
			shotRate = 0.25f;
			nextShot = 0.0f;
			ShotButton = "Jump";
		}
	}
}