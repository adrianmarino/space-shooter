using UnityEngine;

namespace SpaceShooter
{
	public class DestroyByContact : Core.GameElement
	{
		void OnTriggerExit (Collider other)
		{
			Destroy (other.gameObject);
		}
	}
}