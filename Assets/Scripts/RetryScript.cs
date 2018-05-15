using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RetryScript : MonoBehaviour {
	
	Canvas canvas;

	// Use this for initialization
	void Start () {
		canvas.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Retry(){
		canvas.enabled = true;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void toGameScene(){
		SceneManager.LoadScene("Main");
	}
}
