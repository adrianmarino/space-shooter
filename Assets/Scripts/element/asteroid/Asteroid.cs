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
			if (other.tag == "GameArea")
				return;
			destroyObjects (other);
		}

		void Start ()
		{
			setVerticalRotation ();
			applyVelocity (Speed);
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private void destroyObjects (Collider other)
		{	
			Instantiate (explosion, transform.position, transform.rotation);

			destroy (other.gameObject);
			destroy (gameObject);

			if (other.tag == "Spacecraft") {
				Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
				GameElement.instance<Game> ("Game").Finish ();
			}
			if (other.tag == "LaserShot") {
				GameElement.instance<ScorePanel> ("ScorePanel").addScore (10);
			}
		}

		private void setVerticalRotation ()
		{
			getRigidbody ().angularVelocity = Random.insideUnitSphere * tumble;
		}

		private static void destroy (GameObject gameObject)
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

		public ScorePanel ScorePanel {
			get { return scorePanel; }
			set { scorePanel = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private ScorePanel scorePanel;

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
			speed = -4;
		}
	}
}