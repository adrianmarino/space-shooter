using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceShooter.Core;

namespace SpaceShooter
{
	public class RandomRotator : GameElement
	{
		void Start ()
		{
			getRigidbody ().angularVelocity = Random.insideUnitSphere * tumble;
		}

		//-----------------------------------------------------------------------------
		// Properties
		//-----------------------------------------------------------------------------

		public float Tumble {
			get { return tumble; }
			set { tumble = value; }
		}

		//-----------------------------------------------------------------------------
		// Attributes
		//-----------------------------------------------------------------------------

		[SerializeField]
		private float tumble;

		//-----------------------------------------------------------------------------
		// Constructors
		//-----------------------------------------------------------------------------

		public RandomRotator ()
		{
			this.tumble = 3;
		}
	}
}