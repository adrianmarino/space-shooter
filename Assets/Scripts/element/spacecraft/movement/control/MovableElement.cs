using UnityEngine;

namespace SpaceShooter
{
	public interface MovableElement
	{
		void rotate (Quaternion quaternion);

		void velocity (Vector3 vector);

		Vector3 velocity ();

		void position (Vector3 vector);

		Vector3 position ();

		float Speed {
			get;
		}
	}
}