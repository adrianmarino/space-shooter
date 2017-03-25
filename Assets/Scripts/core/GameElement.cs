using System;
using UnityEngine;
using System.Collections;

namespace SpaceShooter.Core
{
	public abstract class GameElement : MonoBehaviour
	{
		//-----------------------------------------------------------------------------
		// Public Static Methods
		//-----------------------------------------------------------------------------

		public static ELEMENT To<ELEMENT> (GameElement element)
		{
			return To<ELEMENT> (element.gameObject);
		}

		public static ELEMENT To<ELEMENT> (GameObject element)
		{
			return element.GetComponent <ELEMENT> ();
		}

		public static void DestroyAllByTag (string tag)
		{
			foreach (GameObject element in GameObject.FindGameObjectsWithTag (tag))
				Destroy (element);
		}

		public static ELEMENT Instance<ELEMENT> (string name)
		{
			GameObject gameObject = GameObject.FindWithTag (name);
			if (gameObject == null)
				throw new Exception ("Cannot find " + name + " object!");
			return To<ELEMENT> (gameObject);
		}

		public static void Instanciate (GameObject obj, float xPosition, float yPosition)
		{
			Vector3 position = Util.Vector3.create (xPosition, yPosition);
			Quaternion rotation = Quaternion.identity;
			Instantiate (obj, position, rotation);
		}

		//-----------------------------------------------------------------------------
		// Public Methods
		//-----------------------------------------------------------------------------

		public void Velocity (Vector3 vector)
		{
			GetRigidbody ().velocity = vector;
		}

		public Vector3 Velocity ()
		{
			return GetRigidbody ().velocity;
		}

		public void Position (Vector3 vector)
		{
			GetRigidbody ().position = vector;
		}

		public void Rotate (Quaternion quaternion)
		{
			GetRigidbody ().rotation = quaternion;
		}

		public Vector3 Position ()
		{
			return GetRigidbody ().position;
		}

		//-----------------------------------------------------------------------------
		// Protected Methods
		//-----------------------------------------------------------------------------

		protected Rigidbody GetRigidbody ()
		{
			return GetComponent<Rigidbody> ();
		}

		protected void ApplyVelocity (float speed)
		{
			Velocity (transform.forward * speed);
		}
	}
}