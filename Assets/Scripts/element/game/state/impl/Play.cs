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
			target.beginAsteroidsGeneration ();
		}

		public override void finish ()
		{
			target.finishAsteroidsGeneration ();
			target.finish ();
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public Play (Game target) : base (target)
		{
		}
	}
}