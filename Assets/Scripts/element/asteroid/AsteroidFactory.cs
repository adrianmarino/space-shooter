using UnityEngine;

namespace SpaceShooter
{
	[System.Serializable]
	public class AsteroidFactory : Core.GameElement
	{
		public void instanciate (GameObject asteroid)
		{
			Asteroid.instanciate (asteroid, Random.Range (MinX, MaxX), InitialY);
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public float MaxX {
			get { return  maxX; }
			set { maxX = value; }
		}

		public float MinX {
			get { return minX; }
			set { minX = value; }
		}

		public float InitialY {
			get { return initialY; }
			set { initialY = value; }
		}

		public float SpawnWait {
			get { return spawnWait; }
			set { spawnWait = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private float minX, maxX;

		[SerializeField]
		private float initialY;

		[SerializeField]
		private float spawnWait;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public AsteroidFactory ()
		{
			InitialY = 15f;
			MinX = -5.5f;
			MaxX = 5.5f;
			spawnWait = 0.5f;
		}
	}
}