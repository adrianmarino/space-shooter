using SpaceShooter;

namespace SpaceShooter
{
	public class Play : GameState<Game>
	{
		public override void begin ()
		{
			target.ScorePanel.reset ();
			target.GameOverPanel.clean ();
			target.StartPanel.clean ();

			target.Spacecraft.instanciate ();
			target.AsteroidGenerator.start ();
		}

		public override void finish ()
		{
			target.AsteroidGenerator.stop ();
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