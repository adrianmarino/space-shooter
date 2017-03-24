using UnityEngine;
using System.Collections;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class LaserWeapon : GameElement
	{
		void Update ()
		{
			if (Input.GetKeyDown (KeyCode.LeftControl) && Time.time > nextShot) {
				nextShot = Time.time + ShotRate;
				Instantiate (LaserShot, transform.position, transform.rotation);
			}
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public GameObject LaserShot {
			get { return laserShot; }
			set { laserShot = value; }
		}

		public float ShotRate {
			get { return shotRate; }
			set { shotRate = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private GameObject laserShot;

		[SerializeField]
		private float shotRate;

		[SerializeField]
		private float nextShot;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public LaserWeapon ()
		{
			shotRate = 0.25f;
			nextShot = 0.0f;
		}
	}
}