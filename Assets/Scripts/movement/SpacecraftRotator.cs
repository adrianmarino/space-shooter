using UnityEngine;
using System.Collections;
using SpaceShooter;
using System.Linq.Expressions;

[System.Serializable]
public class SpacecraftRotator
{
	public void update (Spacecraft element)
	{
		element.rotate (Quaternion.Euler (0.0f, 0.0f, element.velocity ().x * -element.Tilt));
	}
}

