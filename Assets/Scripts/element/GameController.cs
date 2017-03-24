using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceShooter.Core;
using UnityEditor.AnimatedValues;

namespace SpaceShooter
{
	public class GameController : GameElement
	{
		void Start ()
		{
			asteriodFactory.instanciateWave (asteriods, AsteroidWaveSize);
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

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private AsteroidFactory asteriodFactory;

		[SerializeField]
		private int asteroidWaveSize;

		[SerializeField]
		private List<GameObject> asteriods;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public GameController ()
		{
			asteroidWaveSize = 1;
		}
	}
}