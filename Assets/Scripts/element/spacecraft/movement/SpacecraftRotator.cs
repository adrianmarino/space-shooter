using UnityEngine;

namespace SpaceShooter
{
	[System.Serializable]
	public class SpacecraftRotator
	{
		public void Update (Spacecraft element)
		{
			element.Rotate (Quaternion.Euler (0.0f, 0.0f, element.Velocity ().x * -element.Tilt));
		}
	}
}
