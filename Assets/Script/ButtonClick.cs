using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	public void Exit(){
	
	}

	public void Resume(){
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	public void Pause(){
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void Quit(){
		Application.Quit ();
	}

	public void BackToMainMenu(){
		SceneManager.LoadScene ("main menu");
	}

	public void GoToStage(){
		SceneManager.LoadScene ("stage");
	}

	public void GoToTutorial(){
		SceneManager.LoadScene ("projek");
	}

	public void GoToLevel1(){
		SceneManager.LoadScene ("level1");
	}

	public void GoToLevel2(){
		SceneManager.LoadScene ("level2");
	}
}
