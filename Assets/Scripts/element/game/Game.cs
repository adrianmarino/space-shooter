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

		public GameOverPanel GameOverPanel {
			get { return gameOverPanel; }
			set { gameOverPanel = value; }
		}

		public StartPanel StartPanel {
			get { return startPanel; }
			set { startPanel = value; }
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

		public Spacecraft Spacecraft {
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
		private GameOverPanel gameOverPanel;

		[SerializeField]
		private StartPanel startPanel;

		[SerializeField]
		private ScorePanel scorePanel;

		[SerializeField]
		private Spacecraft spacecraft;

		[SerializeField]
		private AsteroidGenerator asteroidGenerator;

		private GameState<Game> state;
	}
}