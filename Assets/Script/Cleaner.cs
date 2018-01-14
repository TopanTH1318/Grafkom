using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour {

	public static bool GameIsPaused = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Player") {
			PlayerHealth playerFall = other.GetComponent<PlayerHealth> ();
			playerFall.makeDead ();
			Time.timeScale = 0f;
			GameIsPaused = true;
		} else
			Destroy (other.gameObject);
	}
}
