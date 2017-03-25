using UnityEngine;
using System.Collections;
using SpaceShooter;

namespace SpaceShooter
{
	public class Initial : GameState<Game>
	{
		public override void begin ()
		{
			target.cleanGameOverText ();
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

		public Initial (Game target) : base (target)
		{
		}
	}
}
