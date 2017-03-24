using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class Asteroid : GameElement
	{
		void OnTriggerEnter (Collider other)
		{
			if (other.tag == "Boundary")
				return;
			destroyObjects (other);
		}

		void Start ()
		{
			setVerticalRotation ();
			applyVelocity (Speed);
		}

		public static void instanciate (GameObject asteriod, float x, float y)
		{
			Vector3 position = Util.Vector3.create (x, y);
			Quaternion rotation = Quaternion.identity;
			Instantiate (asteriod, position, rotation);
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private void destroyObjects (Collider other)
		{	
			Instantiate (explosion, transform.position, transform.rotation);
			if (other.tag == "Player")
				Instantiate (playerExplosion, other.transform.position, other.transform.rotation);

			destroy (other.gameObject);
			destroy (gameObject);
		}

		private void setVerticalRotation ()
		{
			getRigidbody ().angularVelocity = Random.insideUnitSphere * tumble;
		}

		private void destroy (GameObject gameObject)
		{
			Destroy (gameObject);
			Debug.Log (gameObject.tag + " destroyed!");
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public float Tumble {
			get { return tumble; }
			set { tumble = value; }
		}

		public GameObject Explosion {
			get { return explosion; }
			set { explosion = value; }
		}

		public GameObject PlayerExplosion {
			get { return playerExplosion; }
			set { playerExplosion = value; }
		}

		public float Speed {
			get { return speed; }
			set {
				speed = value;
				applyVelocity (speed);
			}
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private float speed;

		[SerializeField]
		private float tumble;

		[SerializeField]
		private GameObject explosion;

		[SerializeField]
		private GameObject playerExplosion;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public Asteroid ()
		{
			tumble = 3;
			speed = 1;
		}
	}
}