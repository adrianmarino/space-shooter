using UnityEngine;

namespace SpaceShooter
{
	public class Spacecraft : Core.GameElement, MovableElement
	{
		//-----------------------------------------------------------------------------
		// Engine events
		//-----------------------------------------------------------------------------

		void Update ()
		{
			verticalRotator.Update (this);
			movementController.UpdatePosition (this, Util.Input.NextDirection ());
		}
			
		//-----------------------------------------------------------------------------
		// Public Methods
		//-----------------------------------------------------------------------------

		public void Instanciate ()
		{
			Core.GameElement.Instanciate (this.gameObject, 0, 0);
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

		public MovementController MovementControler {
			get { return MovementControler; }
			set { MovementControler = value; }
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