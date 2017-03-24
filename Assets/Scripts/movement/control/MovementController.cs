using UnityEngine;
using System.Collections;
using SpaceShooter;
using System;

namespace SpaceShooter
{
	[System.Serializable]
	public class MovementController
	{
		public void updatePosition (MovableElement element, Vector2 direction)
		{
			element.velocity (Util.Vector3.create (direction.x, direction.y) * element.Speed);
			// logDirectionVector (direction.x, direction.y);

			element.position (Boundary.clamp (element.position ()));
			// logPosition (element.position ());
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private void logDirectionVector (float x, float y)
		{
			Debug.Log (string.Format ("Direction=({0}, {1})", Math.Round (x, 1), Math.Round (y, 1)));
		}

		private void logPosition (Vector3 position)
		{
			Debug.Log (string.Format ("Position=({0}, {1})", Math.Round (position.x, 1), Math.Round (position.z, 1)));
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		public MovementBoundary Boundary {
			get { return boundary; }
			set { boundary = value; }
		}
		
		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private MovementBoundary boundary;

		//--------------------------------------------------------------
		// Constructors
		//--------------------------------------------------------------

		public MovementController ()
		{
			boundary = new MovementBoundary ();
		}
	}
}

