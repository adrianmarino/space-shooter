using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	[System.Serializable]
	public class GameContext
	{
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
	}
}
