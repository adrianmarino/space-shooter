using SpaceShooter;

namespace SpaceShooter
{
	public class Play : GameState<Game, GameContext>
	{
		public override void begin (GameContext context)
		{
			context.ScorePanel.reset ();
			context.GameOverPanel.clean ();
			context.StartPanel.clean ();

			context.Spacecraft.instanciate ();
			context.AsteroidGenerator.start ();
		}

		public override void finish (GameContext context)
		{
			context.AsteroidGenerator.stop ();
			game.finish ();
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public Play (Game game) : base (game)
		{
		}
	}
}