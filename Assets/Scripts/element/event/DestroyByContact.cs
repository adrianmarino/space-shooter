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
			Destroy (other.gameObject);
		}
	}
}