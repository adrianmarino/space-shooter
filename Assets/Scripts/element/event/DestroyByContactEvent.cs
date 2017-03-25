using UnityEngine;

namespace SpaceShooter
{
	public class DestroyByContactEvent : Core.GameElement
	{
		//-----------------------------------------------------------------------------
		// Engine Events
		//-----------------------------------------------------------------------------

		void OnTriggerExit (Collider other)
		{
			Destroy (other.gameObject);
		}
	}
}