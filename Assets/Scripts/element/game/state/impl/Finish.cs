using UnityEngine;

namespace SpaceShooter
{
	public class Finish : GameState<Game>
	{
		public override void begin ()
		{
			target.GameOverPanel.show ();
			target.StartPanel.show ();
		}

		public override void update ()
		{
			if (Input.GetKeyDown (KeyCode.S))
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

