﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RetryScript : MonoBehaviour {
	


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void toGameScene(){
		if(Input.GetKey (KeyCode.Space)){
		SceneManager.LoadScene("Main");
		}
	}
}
