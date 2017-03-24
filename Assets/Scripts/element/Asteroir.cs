using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceShooter.Core;

public class Asteroir : GameElement
{
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Boundary")
			return;
		// Destroy object that inpect with own object.
		Destroy (other.gameObject);
		// Destroy own object.
		Destroy (gameObject);
	}

	void Start ()
	{
		getRigidbody ().angularVelocity = Random.insideUnitSphere * tumble;
	}

	//-----------------------------------------------------------------------------
	// Properties
	//-----------------------------------------------------------------------------

	public float Tumble {
		get { return tumble; }
		set { tumble = value; }
	}

	//-----------------------------------------------------------------------------
	// Attributes
	//-----------------------------------------------------------------------------

	[SerializeField]
	private float tumble;

	//-----------------------------------------------------------------------------
	// Constructors
	//-----------------------------------------------------------------------------

	public Asteroir ()
	{
		this.tumble = 3;
	}
}
