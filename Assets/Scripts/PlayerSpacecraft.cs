using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Linq;

public class PlayerSpacecraft : GameElement
{
	void Update ()
	{
		updateMovement ();
	}

	//-----------------------------------------------------------------------------
	// Private Methods
	//-----------------------------------------------------------------------------

	private void updateMovement ()
	{
		float x = InputUtils.nextHorizontalMovement ();
		float y = InputUtils.nextVerticalMovement ();
		velocity (Vector.create (x, y) * Speed);
		position (boundary.clamp (position ()));

		logDirectionVector (x, y);
		logPosition (position ());

		rotate (Quaternion.Euler (0.0f, 0.0f, velocity ().x * -tilt));
	}

	private void logDirectionVector (float x, float y)
	{
		Debug.Log (string.Format ("Direction=({0}, {1})", Math.Round (x, 1), Math.Round (y, 1)));
	}

	private void logPosition (Vector3 position)
	{
		Debug.Log (string.Format ("Position=({0}, {1})", Math.Round (position.x, 1), Math.Round (position.z, 1)));
	}

	//-----------------------------------------------------------------------------
	// Properties
	//-----------------------------------------------------------------------------

	public float Speed {
		get { return speed; }
		set { speed = value; }
	}

	public float Tilt {
		get { return tilt; }
		set { tilt = value; }
	}

	public Boundary Boundary {
		get { return boundary; }
		set { boundary = value; }
	}

	//-----------------------------------------------------------------------------
	// Attributes
	//-----------------------------------------------------------------------------

	[SerializeField]
	private float speed;

	[SerializeField]
	private float tilt;

	[SerializeField]
	private Boundary boundary;

	//-----------------------------------------------------------------------------
	// Constructors
	//-----------------------------------------------------------------------------
	
	public PlayerSpacecraft ()
	{
		this.speed = 15;
		this.tilt = 4;
		this.boundary = new Boundary ();
	}
}
