using UnityEngine;

using SpaceShooter;
using System;
using SpaceShooter.Core;

namespace SpaceShooter
{
	[System.Serializable]
	public class MovementController
	{
		public void Update (GameElement element, Vector2 direction)
		{
			element.Velocity (Util.Vector3.create (direction.x, direction.y) * Speed);
			// logDirectionVector (direction.x, direction.y);

			element.Position (Boundary.Clamp (element.Position ()));
			// logPosition (element.position ());
		}

		//-----------------------------------------------------------------------------
		// Private Methods
		//-----------------------------------------------------------------------------

		private void LogDirectionVector (float x, float y)
		{
			Debug.Log (string.Format ("Direction=({0}, {1})", Math.Round (x, 1), Math.Round (y, 1)));
		}

		private void LogPosition (Vector3 position)
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

		public float Speed {
			get { return speed; }
			set { speed = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private MovementBoundary boundary;

		[SerializeField]
		private float speed;

		//--------------------------------------------------------------
		// Constructors
		//--------------------------------------------------------------

		public MovementController ()
		{
			Speed = 15;
			Boundary = new MovementBoundary ();
		}
	}
}

