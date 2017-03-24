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
			generateAsteriodWaves ();
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private void generateAsteriodWaves ()
		{
			Asteroid.instanciate (Asteriod, randomX (), AsteriodInitialY);
		}

		float randomX ()
		{
			return Random.Range (AsteriodMinX, asteriodMaxX);
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public GameObject Asteriod {
			get { return asteriod; }
			set { asteriod = value; }
		}

		public float AsteriodMaxX {
			get { return asteriodMaxX; }
			set { asteriodMaxX = value; }
		}

		public float AsteriodMinX {
			get { return asteriodMinX; }
			set { asteriodMinX = value; }
		}

		public float AsteriodInitialY {
			get { return asteriodInitialY; }
			set { asteriodInitialY = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private float asteriodMinX, asteriodMaxX;

		[SerializeField]
		private float asteriodInitialY;

		[SerializeField]
		private GameObject asteriod;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public GameController ()
		{
			AsteriodInitialY = 0;
			AsteriodMinX = 0;
			AsteriodMaxX = 0;
		}
	}
}