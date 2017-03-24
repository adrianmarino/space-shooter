using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class ScorePanel : GameElement
	{
		public void addScore (long value)
		{
			currentScore = currentScore + value;
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