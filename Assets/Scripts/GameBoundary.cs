﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class GameBoundary : GameElement
	{
		void OnTriggerExit (Collider otherCollider)
		{
			if (Util.GameObject.hasName (otherCollider.gameObject, Player))
				return;

			destroyObjectLog (otherCollider.gameObject);
			Destroy (otherCollider.gameObject);
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private void destroyObjectLog (GameObject gameObject)
		{
			Debug.Log (string.Format ("Destroy {0}!", Util.GameObject.originalName (gameObject)));
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public string Player {
			get { return player; }
			set { player = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private string player;
	}
}