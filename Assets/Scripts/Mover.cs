﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : GameElement
{
	void Start ()
	{
		getRigidbody ().velocity = transform.forward * speed;
	}

	//-----------------------------------------------------------------------------
	// Properties
	//-----------------------------------------------------------------------------

	public float Speed {
		get { return speed; }
		set { speed = value; }
	}

	//-----------------------------------------------------------------------------
	// Attributes
	//-----------------------------------------------------------------------------

	public float speed;
}