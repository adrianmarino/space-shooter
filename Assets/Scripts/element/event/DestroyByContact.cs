using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class DestroyByContact : GameElement
	{
		void OnTriggerExit (Collider other)
		{
			Debug.Log (string.Format ("{0} out of game area!", other.tag));
			ScorePanel.addScore (10);
			Destroy (other.gameObject);
		}
		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public ScorePanel ScorePanel {
			get { return scorePanel; }
			set { scorePanel = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private ScorePanel scorePanel;
	}
}