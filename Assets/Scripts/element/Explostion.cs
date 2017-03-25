using UnityEngine;

namespace SpaceShooter
{
	public class Explostion : Core.GameElement
	{
		//-----------------------------------------------------------------------------
		// Engine Events
		//-----------------------------------------------------------------------------

		void Start ()
		{
			Destroy (gameObject, LifeTime);	
		}

		//--------------------------------------------------------------
		// Public Static Methods
		//--------------------------------------------------------------

		public static void DestroyAll ()
		{
			Core.GameElement.DestroyAllByTag ("Explosion");
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public float LifeTime {
			get { return lifeTime; }
			set { lifeTime = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private float lifeTime;

		//--------------------------------------------------------------
		// Constructors
		//--------------------------------------------------------------

		public Explostion ()
		{
			lifeTime = 3;
		}
	}
}
