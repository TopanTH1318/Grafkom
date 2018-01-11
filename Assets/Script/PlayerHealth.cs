﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public float fullHealth;
	public GameObject deathFX;

	float currHealth;

	PlayerMovement controlMovement;

	//HUD Variables
	public Slider healthSlider;
	public Image damageScreen;

	bool damaged = false;
	Color damagedColour=new Color(0f,0f,0f,0.5f);
	float smoothColour = 5f;

	// Use this for initialization
	void Start () {
		currHealth = fullHealth;
		controlMovement = GetComponent<PlayerMovement>();

		//HUD initilization
		healthSlider.maxValue=fullHealth;
		healthSlider.value = fullHealth;

		damaged = false;
		print (currHealth);
	}
	
	// Update is called once per frame
	void Update () {
		if (damaged) {
			damageScreen.color = damagedColour;
		} else {
			damageScreen.color = Color.Lerp (damageScreen.color, Color.clear, smoothColour * Time.deltaTime);
		}
		damaged = false;
		print (currHealth);
	}

	public void addDamage(float damage){
		if (damage <= 0)
			return;
		currHealth -= damage;
		healthSlider.value = currHealth;
		damaged = true;
		if (currHealth <= 0) {
			makeDead ();
		}
	}

	public void makeDead(){
		Instantiate (deathFX, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}