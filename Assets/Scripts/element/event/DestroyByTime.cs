using UnityEngine;

namespace SpaceShooter
{
	public class DestroyByTime : Core.GameElement
	{
		void Start ()
		{
			Destroy (gameObject, LifeTime);	
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

		public DestroyByTime ()
		{
			lifeTime = 3;
		}
	}
}
