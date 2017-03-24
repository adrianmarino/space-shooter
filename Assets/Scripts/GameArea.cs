using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class GameArea : GameElement
	{
		void OnTriggerExit (Collider other)
		{
			// Debug.Log (string.Format ("{0} out of boundary!", other.tag));
			Destroy (other.gameObject);
		}
	}
}