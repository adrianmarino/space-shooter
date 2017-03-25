using UnityEngine;

namespace SpaceShooter
{
	public class Spacecraft : Core.GameElement, MovableElement
	{
		void Update ()
		{
			verticalRotator.update (this);
			movementController.updatePosition (this, Util.Input.nextDirection ());
		}

		public void OnDestroy ()
		{
			Instantiate (Explosion, transform.position, transform.rotation);
			Debug.Log (gameObject.tag + " destroyed!");
			Game.Instance ().Finish ();
		}

		//--------------------------------------------------------------
		// Public Static Methods
		//--------------------------------------------------------------

		public static Spacecraft from (GameObject obj)
		{
			return Core.GameElement.to<Spacecraft> (obj);
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

		public GameObject Explosion {
			get { return explosion; }
			set { explosion = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private GameObject explosion;

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