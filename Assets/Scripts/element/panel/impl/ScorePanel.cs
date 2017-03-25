using UnityEngine.UI;
using UnityEngine;

namespace SpaceShooter
{
	public class ScorePanel : TextPanel
	{
		//--------------------------------------------------------------
		// Engine Events
		//--------------------------------------------------------------

		void Start ()
		{
			Reset ();
		}

		//--------------------------------------------------------------
		// Public Static Methods
		//--------------------------------------------------------------

		public static ScorePanel Instance ()
		{
			return Core.GameElement.Instance<ScorePanel> ("ScorePanel");
		}

		//-----------------------------------------------------------------------------
		// Public Methods
		//-----------------------------------------------------------------------------

		public long AddScore (long value)
		{
			return set (score + value);
		}

		public long Reset ()
		{
			return set (0);
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private long set (long value)
		{
			score = value;
			Value = "Score " + value;
			return value;
		}
	
		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private long score;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public ScorePanel ()
		{
			score = 0;
		}
	}
}
