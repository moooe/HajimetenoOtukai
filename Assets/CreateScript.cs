using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScript : MonoBehaviour {

	public GameObject Street1;
	public GameObject Street2;

	float border = -62.5f;

	void Update (){
		if (transform.position.z > border) {
			MoveStreet ();
		}
	}

	void MoveStreet(){
		if (Street1.transform.position.z < Street2.transform.position.z) {
			Street1.transform.position += new Vector3(0,0,190);
			border += 95;
			} 
			else{
				Street2.transform.position += new Vector3(0,0,190);
				border += 95;
				}
	}
	// Use this for initialization
	
}
