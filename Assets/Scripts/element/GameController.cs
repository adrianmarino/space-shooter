using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceShooter;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class GameController : GameElement
	{
		void Start ()
		{
			StartCoroutine (nextAsteroidWave ());
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private IEnumerator nextAsteroidWave ()
		{
			yield return new WaitForSeconds (AsteroidWaveWait);
			while (true) {
				asteriodFactory.instanciateWave (asteriods, AsteroidWaveSize);
				yield return new WaitForSeconds (AsteroidWaveWait);
			}
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

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public GameController ()
		{
			asteroidWaveSize = 1;
			asteroidWaveWait = 2f;
		}
	}
}