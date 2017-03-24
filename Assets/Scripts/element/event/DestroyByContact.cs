using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class DestroyByContact : GameElement
	{
		void OnTriggerExit (Collider other)
		{
			Destroy (other.gameObject);
		}
	}
}