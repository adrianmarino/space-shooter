using SpaceShooter;

namespace SpaceShooter
{
	public class Play : GameState<Game, GameContext>
	{
		public override void Begin (GameContext context)
		{
			context.ScorePanel.Reset ();
			context.GameOverPanel.Clean ();
			context.StartPanel.Clean ();

			context.Spacecraft.Instanciate ();
			context.AsteroidGenerator.Begin ();
		}

		public override void Finish (GameContext context)
		{
			context.AsteroidGenerator.End ();
			game.ChangeToFinish ();
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public Play (Game game) : base (game)
		{
		}
	}
}