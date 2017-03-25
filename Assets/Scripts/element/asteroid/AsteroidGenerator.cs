using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace SpaceShooter
{
	public class AsteroidGenerator : Core.GameElement
	{
		//--------------------------------------------------------------
		// Public Methods
		//--------------------------------------------------------------

		public void Begin ()
		{
			StartCoroutine (NextAsteroidWave ());
		}

		public void End ()
		{
			generateAsteroids = false;
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private IEnumerator NextAsteroidWave ()
		{
			generateAsteroids = true;
			yield return new WaitForSeconds (AsteroidWaveWait);
			while (generateAsteroids) {
				for (int i = 0; i < AsteroidWaveSize; i++) {
					foreach (GameObject asteroid in Asteriods) {
						asteriodFactory.Instanciate (asteroid);
						yield return new WaitForSeconds (AsteroidWaveWait);
						if (!generateAsteroids)
							Asteroid.DestroyAll ();
					}
				}
			}
			yield return new WaitForSeconds (AsteroidWaveWait);
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public AsteroidFactory AsteriodFactory {
			get { return asteriodFactory; }
			set { asteriodFactory = value; }
		}

		public int AsteroidWaveSize {
			get { return asteroidWaveSize; }
			set { asteroidWaveSize = value; }
		}

		public List<GameObject> Asteriods {
			get { return asteriods; }
			set { asteriods = value; }
		}

		public float AsteroidWaveWait {
			get { return asteroidWaveWait; }
			set { asteroidWaveWait = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private AsteroidFactory asteriodFactory;

		[SerializeField]
		private int asteroidWaveSize;

		[SerializeField]
		private float asteroidWaveWait;

		[SerializeField]
		private List<GameObject> asteriods;

		private bool generateAsteroids;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public AsteroidGenerator ()
		{
			asteroidWaveSize = 1;
			asteroidWaveWait = 2f;
		}
	}
}
