using UnityEngine;
using System.Collections;
using UnityEditor;

public class LaserWeapon : GameElement
{
	void Update ()
	{
		if (Input.GetButton (ButtonName) && Time.time > nextShot) {
			nextShot = Time.time + ShotRate;
			Instantiate (LaserShot, transform.position, transform.rotation);
		}
	}

	//-----------------------------------------------------------------------------
	// Properties
	//-----------------------------------------------------------------------------

	public GameObject LaserShot {
		get { return laserShot; }
		set { laserShot = value; }
	}

	public float ShotRate {
		get { return shotRate; }
		set { shotRate = value; }
	}

	public string ButtonName {
		get { return buttonName; }
		set { buttonName = value; }
	}

	//-----------------------------------------------------------------------------
	// Attributes
	//-----------------------------------------------------------------------------

	[SerializeField]
	private GameObject laserShot;

	[SerializeField]
	private float shotRate;

	[SerializeField]
	private string buttonName;

	[SerializeField]
	private float nextShot;

	//-----------------------------------------------------------------------------
	// Constructors
	//-----------------------------------------------------------------------------

	public LaserWeapon ()
	{
		shotRate = 0.25f;
		nextShot = 0.0f;
		buttonName = "Jump";
	}
}