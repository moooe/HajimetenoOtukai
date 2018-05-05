using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScript : MonoBehaviour {

	public GameObject Street1;
	public GameObject Street2;

	float border = -62.5f;

	void Update (){
		if (transform.position.z > border) {
			CreateMap ();
		}
	}

	void CreateMap(){
		if (Street1.transform.position.z < border) {
			border += 95;
			Vector3 temp = new Vector3 (-314.48f,70.945f,border);
			Street1.transform.position = temp;
		} else if (Street2.transform.position.z < border) {
			border += 95;
			Vector3 temp = new Vector3 (-314.48f,70.945f,border);
			Street2.transform.position = temp;
		}
	}
	// Use this for initialization
	
}
