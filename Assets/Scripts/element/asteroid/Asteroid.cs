using UnityEngine;

namespace SpaceShooter
{
	public class Asteroid :  Core.GameElement
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

		public static void destroyAll ()
		{
			Core.GameElement.destroyAllByTag ("Asteroid");
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
				Core.GameElement.instance<Game> ("Game").Finish ();
			}
			if (other.tag == "LaserShot") {
				Core.GameElement.instance<ScorePanel> ("ScorePanel").addScore (pointsByAsteriod);
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

		public int PointsByAsteriod {
			get { return pointsByAsteriod; }
			set { pointsByAsteriod = value; }
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

		[SerializeField]
		private int pointsByAsteriod;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public Asteroid ()
		{
			tumble = 3;
			speed = -4;
			pointsByAsteriod = 10;
		}
	}
}