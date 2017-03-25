using UnityEngine;

namespace SpaceShooter
{
	public class Finish : GameState<Game>
	{
		public override void begin ()
		{
			target.showGameOver ();
			target.showRestart ();
		}

		public override void update ()
		{
			if (Input.GetKeyDown (KeyCode.R))
				target.play ();
		}

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public Finish (Game target) : base (target)
		{
		}
	}
}

