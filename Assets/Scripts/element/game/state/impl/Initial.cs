using UnityEngine;
using System.Collections;
using SpaceShooter;

namespace SpaceShooter
{
	public class Initial : GameState<Game, GameContext>
	{
		public override void Begin (GameContext context)
		{
			context.GameOverPanel.Clean ();
			context.StartPanel.Show ();
		}

		public override void Update (GameContext context)
		{
			if (Input.GetKeyDown (KeyCode.S))
				game.ChangeToPlay ();
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public Initial (Game game) : base (game)
		{
		}
	}
}
