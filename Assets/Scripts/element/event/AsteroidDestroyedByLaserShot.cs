using UnityEngine;

namespace SpaceShooter
{
	public class AsteroidDestroyedByLaserShot : Core.GameElement
	{
		//-----------------------------------------------------------------------------
		// Engine events
		//-----------------------------------------------------------------------------

		void OnTriggerEnter (Collider other)
		{
			if (other.tag == "LaserShot")
				ScorePanel.Instance ().addScore (pointsByAsteriod); 
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public int PointsByAsteriod {
			get { return pointsByAsteriod; }
			set { pointsByAsteriod = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private int pointsByAsteriod;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public AsteroidDestroyedByLaserShot ()
		{
			this.pointsByAsteriod = 10;
		}
	}
}