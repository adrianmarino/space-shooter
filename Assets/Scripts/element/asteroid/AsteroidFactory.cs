using UnityEngine;
using System.Collections;
using SpaceShooter;
using NUnit.Framework;
using System.Collections.Generic;
using SpaceShooter.Core;

namespace SpaceShooter
{
	[System.Serializable]
	public class AsteroidFactory : GameElement
	{
		public void instanciateWave (List<GameObject> asteroids, int sizeByElement)
		{
			for (int i = 0; i < sizeByElement; i++)
				instanciate (asteroids);
		}

		public void instanciate (List<GameObject> asteroids)
		{
			StartCoroutine (instanciateRoutine (asteroids));
		}

		public void instanciate (GameObject asteroid)
		{
			Asteroid.instanciate (asteroid, Random.Range (MinX, MaxX), InitialY);
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private IEnumerator instanciateRoutine (List<GameObject> asteroids)
		{
			foreach (GameObject asteroid in asteroids) {
				instanciate (asteroid);
				yield return new WaitForSeconds (SpawnWait);
			}
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