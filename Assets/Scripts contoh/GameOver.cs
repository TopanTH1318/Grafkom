﻿using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	}
	
	void OnGUI(){
		
		//if retry button is pressed load scene 0 the game
		GUI.contentColor = Color.red;
		if(GUI.Button(new Rect(Screen.width/2-50,Screen.height/2 +150,100,40),"Retry?")){
			Application.LoadLevel(0);
		}
		//and quit button
		if(GUI.Button(new Rect(Screen.width/2-50,Screen.height/2 +200,100,40),"Quit")){
			Application.Quit();
		}
	}
	
}