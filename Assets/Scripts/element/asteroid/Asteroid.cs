using UnityEngine;

namespace SpaceShooter
{
	public class Asteroid :  Core.GameElement
	{
		void OnTriggerEnter (Collider other)
		{
			if (other.tag == "GameArea")
				return;

			Destroy (gameObject);
			Destroy (other.gameObject);

			if (other.tag == "LaserShot")
				ScorePanel.Instance ().addScore (pointsByAsteriod); 
		}

		void Start ()
		{
			setVerticalRotation ();
			applyVelocity (Speed);
		}

		void OnDestroy ()
		{
			Instantiate (Explosion, transform.position, transform.rotation);
			Debug.Log (gameObject.tag + " destroyed!");
		}

		//--------------------------------------------------------------
		// Public Static Methods
		//--------------------------------------------------------------
	
		public static void destroyAll ()
		{
			Core.GameElement.destroyAllByTag ("Asteroid");
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private void setVerticalRotation ()
		{
			getRigidbody ().angularVelocity = Random.insideUnitSphere * tumble;
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

		public float Speed {
			get { return speed; }
			set {
				speed = value;
				applyVelocity (speed);
			}
		}

		public int PointsByAsteriod {
			get { return pointsByAsteriod; }
			set { pointsByAsteriod = value; }
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