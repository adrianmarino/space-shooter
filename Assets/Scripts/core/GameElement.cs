using System;
using UnityEngine;

namespace SpaceShooter.Core
{
	public abstract class GameElement : MonoBehaviour
	{
		public void velocity (Vector3 vector)
		{
			getRigidbody ().velocity = vector;
		}

		public Vector3 velocity ()
		{
			return getRigidbody ().velocity;
		}

		public void position (Vector3 vector)
		{
			getRigidbody ().position = vector;
		}

		public void rotate (Quaternion quaternion)
		{
			getRigidbody ().rotation = quaternion;
		}

		public Vector3 position ()
		{
			return getRigidbody ().position;
		}

		protected Rigidbody getRigidbody ()
		{
			return GetComponent<Rigidbody> ();
		}
	}
}