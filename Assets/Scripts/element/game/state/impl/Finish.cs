using UnityEngine;

namespace SpaceShooter
{
	public class Finish : GameState<Game, GameContext>
	{
		public override void begin (GameContext context)
		{
			context.GameOverPanel.show ();
			context.StartPanel.show ();
		}

		public override void update (GameContext context)
		{
			if (Input.GetKeyDown (KeyCode.S))
				game.play ();
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public Finish (Game game) : base (game)
		{
		}
	}
}

