using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartClickScript : MonoBehaviour {
	public GameObject button;
	public GameObject text;
	public PlayerScript playerScript;
	public TimeScript timeScript;
	public CreateScript createScript;
	public Text goalText;


	// Use this for initialization
	void Start () {
		goalText.enabled = false; // テキストを非表示にしておく
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void StartButton(){
			Destroy (button);
			Destroy (text);
			playerScript.enabled = true;
			timeScript.enabled = true;
			createScript.enabled = true;
	}
}
