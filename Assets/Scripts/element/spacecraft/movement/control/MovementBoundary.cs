using UnityEngine;

namespace SpaceShooter
{
	[System.Serializable]
	public class MovementBoundary
	{

		public Vector3 clamp (Vector3 vector)
		{
			return Util.Vector3.create (
				Mathf.Clamp (vector.x, Xmin, Xmax), 
				Mathf.Clamp (vector.z, Ymin, Ymax)
			);
		}

		public float Xmin {
			get { return xMin; }
			set { xMin = value; }
		}

		public float Xmax {
			get { return xMax; }
			set { xMax = value; }
		}

		public float Ymin {
			get { return yMin; }
			set { yMin = value; }
		}

		public float Ymax {
			get { return yMax; }
			set { yMax = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private float xMin, xMax, yMin, yMax;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public MovementBoundary ()
		{
			this.Xmin = 0f;
			this.Xmax = 0f;
			this.Ymin = 0f;
			this.Ymax = 0f;
		}
	}
}
