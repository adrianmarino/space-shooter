using System;
using UnityEngine;

public abstract class GameElement : MonoBehaviour
{
	protected void velocity (Vector3 vector)
	{
		getRigidbody ().velocity = vector;
	}

	protected Vector3 velocity ()
	{
		return getRigidbody ().velocity;
	}

	protected void position (Vector3 vector)
	{
		getRigidbody ().position = vector;
	}

	protected void rotate (Quaternion quaternion)
	{
		getRigidbody ().rotation = quaternion;
	}

	protected Vector3 position ()
	{
		return getRigidbody ().position;
	}

	protected Rigidbody getRigidbody ()
	{
		return GetComponent<Rigidbody> ();
	}
}
