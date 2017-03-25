using UnityEngine;
using System.Collections;
using SpaceShooter;

namespace SpaceShooter
{
	public class Initial : GameState<Game, GameContext>
	{
		public override void begin (GameContext context)
		{
			context.GameOverPanel.clean ();
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

		public Initial (Game game) : base (game)
		{
		}
	}
}
