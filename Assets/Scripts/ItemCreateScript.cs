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
		float x = Random.Range(-5.7f,1.5f);
		float z = Random.Range(-77.0f,204.0f);
		
		for(int i = 1;i <= 5;i++){
			x = Random.Range(-5.7f,1.5f);
		    z = Random.Range(-77.0f,204.0f);
		    Instantiate (Apple, new Vector3(x,-28.4f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 5;i++){
			x = Random.Range(-5.7f,1.5f);
		    z = Random.Range(-77.0f,204.0f);
		    Instantiate (banana, new Vector3(x,-28.1f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 5;i++){
			x = Random.Range(-5.7f,1.5f);
		    z = Random.Range(-77.0f,204.0f);
		    Instantiate (Bottle, new Vector3(x,-28.4f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 5;i++){
			x = Random.Range(-5.7f,1.5f);
		    z = Random.Range(-77.0f,204.0f);
		    Instantiate (Can, new Vector3(x,-28.4f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 5;i++){
			x = Random.Range(-5.7f,1.5f);
		    z = Random.Range(-77.0f,204.0f);
		    Instantiate (Can_Orange, new Vector3(x,-28.4f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 5;i++){
			x = Random.Range(-5.7f,1.5f);
		    z = Random.Range(-77.0f,204.0f);
		    Instantiate (Chips, new Vector3(x,-28.4f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 5;i++){
			x = Random.Range(-5.7f,1.5f);
		    z = Random.Range(-77.0f,204.0f);
		    Instantiate (Milk, new Vector3(x,-28.4f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 5;i++){
			x = Random.Range(-5.7f,1.5f);
		    z = Random.Range(-77.0f,204.0f);
		    Instantiate (Onion, new Vector3(x,-28.4f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 5;i++){
			x = Random.Range(-5.7f,1.5f);
		    z = Random.Range(-77.0f,204.0f);
		    Instantiate (Tomato, new Vector3(x,-28.4f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 5;i++){
			x = Random.Range(-5.7f,1.5f);
		    z = Random.Range(-77.0f,204.0f);
		    Instantiate (candy, new Vector3(x,-27.8f,z),Quaternion.identity);
		}
		for(int i = 1;i <= 5;i++){
			x = Random.Range(-5.7f,1.5f);
		    z = Random.Range(-77.0f,204.0f);
		    Instantiate (Rock, new Vector3(x,-28.0f,z),Quaternion.identity);
		}
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
