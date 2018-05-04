using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScript : MonoBehaviour {

	public GameObject course1;
	public GameObject course2;

	int border = 5;

	void Update (){
		if (transform.position.z > border) {
			CreateMap ();
		}
	}

	void CreateMap(){
		if (course1.transform.position.z < border) {
			border += 30;
			Vector3 temp = new Vector3 (0,-0.49f,border);
			course1.transform.position = temp;
		} else if (course2.transform.position.z < border) {
			border += 30;
			Vector3 temp = new Vector3 (0,-0.49f,border);
			course2.transform.position = temp;
		}
	}

	// Use this for initialization
	
}
