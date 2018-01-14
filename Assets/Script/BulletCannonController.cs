using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCannonController : MonoBehaviour {

	public float PeluruSpeedhigh;
	public float PeluruSpeedLow;
	public float PeluruAngle;
	public float PeluruTorque;

	Rigidbody2D PeluruRB;

	// Use this for initialization
	void Start () {
		PeluruRB = GetComponent<Rigidbody2D> ();
		PeluruRB.AddForce (new Vector2 (Random.Range (-PeluruAngle, PeluruAngle), Random.Range (PeluruSpeedLow, PeluruSpeedhigh)), ForceMode2D.Impulse);
		PeluruRB.AddTorque((Random.Range(-PeluruTorque,PeluruTorque)));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
