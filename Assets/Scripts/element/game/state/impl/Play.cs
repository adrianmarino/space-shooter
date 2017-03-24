using SpaceShooter;

namespace SpaceShooter
{
	public class Play : GameState<Game>
	{
		public override void begin ()
		{
			target.ScorePanel.reset ();
			target.cleanGameOverText ();
			target.cleanRestartText ();
			target.instanciateSpacecraft ();
			target.startGenerateAsteroids ();
		}

		public override void finish ()
		{
			target.endGenerateAsteroids ();
			target.State = new GameOver (target);
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public Play (Game target) : base (target)
		{
		}
	}
}