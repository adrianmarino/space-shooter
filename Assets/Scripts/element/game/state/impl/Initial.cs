using UnityEngine;
using System.Collections;
using SpaceShooter;

namespace SpaceShooter
{
	public class Initial : GameState<Game>
	{
		public override void begin ()
		{
			target.GameOverPanel.clean ();
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

		public Initial (Game target) : base (target)
		{
		}
	}
}
