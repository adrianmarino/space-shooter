using UnityEngine;

namespace SpaceShooter
{
	public class Spacecraft : Core.GameElement
	{
		//-----------------------------------------------------------------------------
		// Engine events
		//-----------------------------------------------------------------------------

		void Update ()
		{
			verticalRotationMovement.Update (this);
			movementController.Update (this, Util.Input.NextDirection ());
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

		public VerstionRotationMovement VerticalRotator {
			get { return verticalRotationMovement; }
			set { verticalRotationMovement = value; }
		}

		public MovementController MovementControler {
			get { return MovementControler; }
			set { MovementControler = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private MovementController movementController;

		[SerializeField]
		private VerstionRotationMovement verticalRotationMovement;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------
	
		public Spacecraft ()
		{
			movementController = new MovementController ();
			verticalRotationMovement = new VerstionRotationMovement ();
		}
	}
}