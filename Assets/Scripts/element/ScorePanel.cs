using UnityEngine;

namespace SpaceShooter
{
	public class ScorePanel : Core.GameElement
	{
		public void addScore (long value)
		{
			currentScore = currentScore + value;
		}

		public void reset ()
		{
			currentScore = 0;
		}

		void Update ()
		{
			update (currentScore);
		}

		void Start ()
		{
			update (currentScore);
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private void update (long value)
		{
			panel.text = "Score " + value;
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public GUIText Panel {
			get { return panel; }
			set { panel = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private GUIText panel;

		[SerializeField]
		private long currentScore;

		//--------------------------------------------------------------
		// Constructors
		//--------------------------------------------------------------

		public ScorePanel ()
		{
			currentScore = 0;	
		}
	}
}