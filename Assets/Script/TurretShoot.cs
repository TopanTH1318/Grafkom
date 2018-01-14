using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour {

	public GameObject Peluru;
	public float shootTime;
	public Transform shootFrom;
	public int chanceShoot;
	public EnemyHealth enemyhealth;
	public GameObject meong;
	float nextShootTime;

	// Use this for initialization
	void Start () {
		nextShootTime = 0f;
		enemyhealth = meong.GetComponent<EnemyHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag=="Player" && nextShootTime < Time.time && enemyhealth.currentHealth>0) {
			nextShootTime = Time.time + shootTime;
			if(Random.Range(1,10)>=chanceShoot){
				Instantiate (Peluru, shootFrom.position, Quaternion.identity);
			}
		}
	}
}
