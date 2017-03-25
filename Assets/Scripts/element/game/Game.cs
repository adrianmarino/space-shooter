using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceShooter;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class Game : GameElement
	{
		void Start ()
		{
			State.begin ();
		}

		void Update ()
		{
			State.update ();
		}

		public void Finish ()
		{
			State.finish ();
		}

		public void cleanRestartText ()
		{
			RestartText.text = "";
		}

		public void cleanGameOverText ()
		{
			GameOverText.text = "";
		}

		public void showRestart ()
		{
			RestartText.text = "Press R to restart";
		}

		public void showGameOver ()
		{
			GameOverText.text = "GAME OVER";
		}

		public void beginAsteroidsGeneration ()
		{
			StartCoroutine (nextAsteroidWave ());
		}

		public IEnumerator nextAsteroidWave ()
		{
			generateAsteroids = true;
			yield return new WaitForSeconds (AsteroidWaveWait);
			while (generateAsteroids) {
				for (int i = 0; i < AsteroidWaveSize; i++) {
					foreach (GameObject asteroid in Asteriods) {
						asteriodFactory.instanciate (asteroid);
						yield return new WaitForSeconds (AsteroidWaveWait);
						if (!generateAsteroids)
							Asteroid.destroyAll ();
					}
				}
			}
		}

		public void finishAsteroidsGeneration ()
		{
			generateAsteroids = false;
		}

		public void instanciateSpacecraft ()
		{
			GameElement.instanciate (spacecraft, 0, 0);
		}

		public void play ()
		{
			State = new Play (this);
		}

		public void finish ()
		{
			State = new Finish (this);
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

		public GUIText GameOverText {
			get { return gameOverText; }
			set { gameOverText = value; }
		}

		public GUIText RestartText {
			get { return restartText; }
			set { restartText = value; }
		}

		public ScorePanel ScorePanel {
			get { return scorePanel; }
			set { scorePanel = value; }
		}

		public GameState<Game> State {
			get { 
				if (state == null)
					state = new Initial (this);
				return state;
			}
			set { 
				state = value;
				state.begin ();
			}
		}

		public GameObject Spacecraft {
			get { return spacecraft; }
			set { spacecraft = value; }
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

		[SerializeField]
		private GUIText gameOverText, restartText;

		[SerializeField]
		private ScorePanel scorePanel;

		[SerializeField]
		private GameObject spacecraft;

		private bool generateAsteroids;

		private GameState<Game> state;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public Game ()
		{
			asteroidWaveSize = 1;
			asteroidWaveWait = 2f;
		}
	}
}