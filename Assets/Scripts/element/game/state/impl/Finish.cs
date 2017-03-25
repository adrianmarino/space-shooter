using UnityEngine;

namespace SpaceShooter
{
	public class Finish : GameState<Game, GameContext>
	{
		public override void Begin (GameContext context)
		{
			context.GameOverPanel.Show ();
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

		public Finish (Game game) : base (game)
		{
		}
	}
}

