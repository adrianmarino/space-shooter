using UnityEngine;

namespace SpaceShooter
{
	public class Game : Core.GameElement
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

		public void instanciateSpacecraft ()
		{
			Core.GameElement.instanciate (spacecraft, 0, 0);
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

		public AsteroidGenerator AsteroidGenerator {
			get { return asteroidGenerator; }
			set { asteroidGenerator = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------
	
		[SerializeField]
		private GUIText gameOverText, restartText;

		[SerializeField]
		private ScorePanel scorePanel;

		[SerializeField]
		private GameObject spacecraft;

		[SerializeField]
		private AsteroidGenerator asteroidGenerator;

		private GameState<Game> state;
	}
}