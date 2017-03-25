using UnityEngine.UI;

namespace SpaceShooter
{
	public class ScorePanel : TextPanel
	{
		//-----------------------------------------------------------------------------
		// Public Methods
		//-----------------------------------------------------------------------------

		public long addScore (long value)
		{
			return update (score + value);
		}

		public long reset ()
		{
			return update (0);
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private long update (long value)
		{
			score = value;
			Text = "Score " + value;
			return value;
		}
	
		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		private long score;
	
		//--------------------------------------------------------------
		// Constructors
		//--------------------------------------------------------------

		public ScorePanel ()
		{
			reset ();
		}
	}
}
