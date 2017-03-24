using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
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

