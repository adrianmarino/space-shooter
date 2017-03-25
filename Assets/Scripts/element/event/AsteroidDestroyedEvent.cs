using UnityEngine;

namespace SpaceShooter
{
	public class AsteroidDestroyedEvent : Core.GameElement
	{
		//-----------------------------------------------------------------------------
		// Engine Events
		//-----------------------------------------------------------------------------

		void OnTriggerEnter (Collider other)
		{
			if (other.tag == "GameArea")
				return;
			DestroyAndExplode (gameObject, AsteriodExplosion);

			if (other.tag == "Spacecraft") {
				DestroyAndExplode (other.gameObject, SpacecraftExplosion);
				Game.Instance ().Finish ();
			}

			if (other.tag == "LaserShot") {
				Destroy (other.gameObject);
				ScorePanel.Instance ().AddScore (pointsByAsteriod); 
			}
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private void DestroyAndExplode (GameObject obj, GameObject explosion)
		{
			Destroy (obj);
			Instantiate (explosion, obj.transform.position, obj.transform.rotation);
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public int PointsByAsteriod {
			get { return pointsByAsteriod; }
			set { pointsByAsteriod = value; }
		}

		public GameObject SpacecraftExplosion {
			get { return spacecraftExplosion; }
			set { spacecraftExplosion = value; }
		}

		public GameObject AsteriodExplosion {
			get { return asteriodExplosion; }
			set { asteriodExplosion = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private GameObject spacecraftExplosion;

		[SerializeField]
		private GameObject asteriodExplosion;

		[SerializeField]
		private int pointsByAsteriod;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public AsteroidDestroyedEvent ()
		{
			this.pointsByAsteriod = 10;
		}
	}
}