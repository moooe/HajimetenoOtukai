using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {
	private float time = 50;
    public PlayerScript playerScript;
	
	public GameObject gameOverText; 
	public GameObject retryText;
	
	bool flag=true;
	

	// Use this for initialization
	void Start () {
		gameOverText.SetActive(false);
		retryText.SetActive(false);
		GetComponent<Text>().text = "TIME : " + ((int)time).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (playerScript.isGoal) // もしPlayerScriptのisGoalがTrueだったら
        {
			flag=false;
        }
        
		if(flag){
		time -= Time.deltaTime;
		}
		if (time < 0) {
			GameOver();
		}
		if (time < 0) time = 0;
		GetComponent<Text>().text = "TIME : " + ((int)time).ToString ();
	}
	void GameOver () {
		gameOverText.SetActive(true);
		retryText.SetActive(true);
		playerScript.Stop2();
		if(Input.GetKey (KeyCode.Space)){
		SceneManager.LoadScene("Main");
		}
	}
}
