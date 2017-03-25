﻿using UnityEngine;

namespace SpaceShooter
{
	public class Spacecraft : Core.GameElement, MovableElement
	{
		void Update ()
		{
			verticalRotator.update (this);
			movementController.updatePosition (this, Util.Input.nextDirection ());
		}

		//-----------------------------------------------------------------------------
		// Public Methods
		//-----------------------------------------------------------------------------

		public void instanciate ()
		{
			Core.GameElement.instanciate (this.gameObject, 0, 0);
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

		public MovementController movementControler {
			get { return movementControler; }
			set { movementControler = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private float speed;

		[SerializeField]
		private float tilt;

		[SerializeField]
		private MovementController movementController;

		[SerializeField]
		private readonly SpacecraftRotator verticalRotator;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------
	
		public Spacecraft ()
		{
			this.speed = 15;
			this.tilt = 4;
			this.movementController = new MovementController ();
			this.verticalRotator = new SpacecraftRotator ();
		}
	}
}