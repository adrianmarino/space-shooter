using UnityEngine;

namespace SpaceShooter
{
	public interface MovableElement
	{
		void Rotate (Quaternion quaternion);

		void Velocity (Vector3 vector);

		Vector3 Velocity ();

		void Position (Vector3 vector);

		Vector3 Position ();

		float Speed {
			get;
		}
	}
}