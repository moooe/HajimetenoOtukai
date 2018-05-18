using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreateScript : MonoBehaviour {
	public GameObject Apple;
	public GameObject banana;
	public GameObject Bottle;
	public GameObject Can;
	public GameObject Can_Orange;
	public GameObject Chips;
	public GameObject Milk;
	public GameObject Onion;
    public GameObject Tomato;
	public GameObject candy;
	public GameObject Rock;


	// Use this for initialization
	void Start () {
		float x = Random.Range(-321.8f,-314.6f);
		float y = 70.18f;
		float z = Random.Range(-108.0f,163.8f);
		
		for(int i = 1;i <= 10;i++){
			x = Random.Range(-321.8f,-314.6f);
		    z = Random.Range(-108.0f,163.8f);
		    Instantiate (Apple, new Vector3(x,y,z),Quaternion.identity);
		}
		for(int i = 1;i <= 10;i++){
			x = Random.Range(-321.8f,-314.6f);
		    z = Random.Range(-108.0f,163.8f);
		    Instantiate (banana, new Vector3(x,70.13f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 10;i++){
			x = Random.Range(-321.8f,-314.6f);
		    z = Random.Range(-108.0f,163.8f);
		    Instantiate (Bottle, new Vector3(x,y,z),Quaternion.identity);
		}
		for(int i = 1;i <= 10;i++){
			x = Random.Range(-321.8f,-314.6f);
		    z = Random.Range(-108.0f,163.8f);
		    Instantiate (Can, new Vector3(x,y,z),Quaternion.identity);
		}
		for(int i = 1;i <= 10;i++){
			x = Random.Range(-321.8f,-314.6f);
		    z = Random.Range(-108.0f,163.8f);
		    Instantiate (Can_Orange, new Vector3(x,y,z),Quaternion.identity);
		}
		for(int i = 1;i <= 10;i++){
			x = Random.Range(-321.8f,-314.6f);
		    z = Random.Range(-108.0f,163.8f);
		    Instantiate (Chips, new Vector3(x,y,z),Quaternion.identity);
		}
		for(int i = 1;i <= 10;i++){
			x = Random.Range(-321.8f,-314.6f);
		    z = Random.Range(-108.0f,163.8f);
		    Instantiate (Milk, new Vector3(x,y,z),Quaternion.identity);
		}
		for(int i = 1;i <= 10;i++){
			x = Random.Range(-321.8f,-314.6f);
		    z = Random.Range(-108.0f,163.8f);
		    Instantiate (Onion, new Vector3(x,y,z),Quaternion.identity);
		}
		for(int i = 1;i <= 10;i++){
			x = Random.Range(-321.8f,-314.6f);
		    z = Random.Range(-108.0f,163.8f);
		    Instantiate (Tomato, new Vector3(x,y,z),Quaternion.identity);
		}
		for(int i = 1;i <= 40;i++){
			x = Random.Range(-321.8f,-314.6f);
		    z = Random.Range(-108.0f,163.8f);
		    Instantiate (candy, new Vector3(x,70.78f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 70;i++){
			x = Random.Range(-321.8f,-314.6f);
		    z = Random.Range(-108.0f,163.8f);
		    Instantiate (Rock, new Vector3(x,70.58f,z),Quaternion.identity);
		}
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
