using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartClickScript : MonoBehaviour {
	public GameObject button;
	public GameObject text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			Destroy (button);
			Destroy (text);
			
		}
		
	}
}
