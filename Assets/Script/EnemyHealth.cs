using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

	public float enemyMaxHealth;

	public GameObject enemyDeathFX;
	public Slider enemyHealthSlider;

	public bool drops;
	public GameObject theDrop;

	public float currentHealth;

	// Use this for initialization
	void Start () {
		currentHealth = enemyMaxHealth;	
		enemyHealthSlider.maxValue = currentHealth;
		enemyHealthSlider.value = currentHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addDamage(float damage){
		enemyHealthSlider.gameObject.SetActive (true);
		currentHealth -= damage;
		enemyHealthSlider.value = currentHealth;
		if (currentHealth <= 0)
			makeDead ();
	}

	void makeDead(){
		Destroy (gameObject);
		Instantiate (enemyDeathFX, transform.position, transform.rotation);
		if (drops)
			Instantiate (theDrop, transform.position, transform.rotation);
	}

}
