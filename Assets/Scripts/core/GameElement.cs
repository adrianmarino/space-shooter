﻿using System;
using UnityEngine;
using System.Collections;

namespace SpaceShooter.Core
{
	public abstract class GameElement : MonoBehaviour
	{
		//-----------------------------------------------------------------------------
		// Public Static Methods
		//-----------------------------------------------------------------------------

		public static ELEMENT to<ELEMENT> (GameElement element)
		{
			return to<ELEMENT> (element.gameObject);
		}

		public static ELEMENT to<ELEMENT> (GameObject element)
		{
			return element.GetComponent <ELEMENT> ();
		}

		public static void destroyAllByTag (string tag)
		{
			foreach (GameObject element in GameObject.FindGameObjectsWithTag (tag))
				Destroy (element);
		}

		public static ELEMENT instance<ELEMENT> (string name)
		{
			GameObject gameObject = GameObject.FindWithTag (name);
			if (gameObject == null)
				throw new Exception ("Cannot find " + name + " object!");
			return to<ELEMENT> (gameObject);
		}

		public static void instanciate (GameObject obj, float xPosition, float yPosition)
		{
			Vector3 position = Util.Vector3.create (xPosition, yPosition);
			Quaternion rotation = Quaternion.identity;
			Instantiate (obj, position, rotation);
		}

		//-----------------------------------------------------------------------------
		// Public Methods
		//-----------------------------------------------------------------------------

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

		//-----------------------------------------------------------------------------
		// Protected Methods
		//-----------------------------------------------------------------------------

		protected Rigidbody getRigidbody ()
		{
			return GetComponent<Rigidbody> ();
		}

		protected void applyVelocity (float speed)
		{
			velocity (transform.forward * speed);
		}
	}
}