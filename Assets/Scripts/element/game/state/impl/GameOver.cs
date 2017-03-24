using UnityEngine;

namespace SpaceShooter
{
	public class GameOver : GameState<Game>
	{
		public override void begin ()
		{
			target.showGameOver ();
			target.showRestart ();
		}

		public override void update ()
		{
			if (Input.GetKeyDown (KeyCode.R))
				target.State = new Play (target);
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public GameOver (Game target) : base (target)
		{
		}
	}
}

