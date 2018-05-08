using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float speed = 3.0f;
	public float slidspeed = 3;
	public float jumpHeight;
	
    private Animator animator;

	// Use this for initialization
	void Start () {
		
		animator = GetComponent <Animator> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.forward * speed * Time.deltaTime;
		float pos_x = transform.position.x;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (pos_x > -321.8f) {
				transform.position += Vector3.left * slidspeed * Time.deltaTime;
			}
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			if (pos_x < -314.5f) {
				transform.position += Vector3.right * slidspeed * Time.deltaTime;
			}
		}



		if (Input.GetKeyDown(KeyCode.UpArrow) && !animator.GetBool("JUMP")){
			animator.SetBool("JUMP", true);
			Invoke("JumpToRun",.7f);
			StartCoroutine(JumpMovement (1f,jumpHeight));
		}
	}

	private void JumpToRun(){
		animator.SetBool("JUMP",false);
		animator.SetBool("RUN",true);
	}

	private IEnumerator JumpMovement(float time, float jumpHeight){
		float startHeight = transform.transform.position.y;
		float starttime = Time.time;
		float elapsedTime = Time.time - starttime;
		Vector3 pos;
		do{
			elapsedTime = Time.time - starttime;
			float height = 4 * jumpHeight * elapsedTime / time * (-elapsedTime / time + 1) + startHeight;
			pos = transform.position;
			transform.position = new Vector3(pos.x, height, pos.z);
			yield return new WaitForEndOfFrame();}
			while (elapsedTime <= time);
			pos = transform.position;
			transform.position = new Vector3(pos.x, startHeight, pos.z);
	} 
}
