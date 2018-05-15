using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class TimeScript : MonoBehaviour {
	private float time = 50;
    public PlayerScript playerScript;
	
	public GameObject gameOverText; 
	RetryScript retryscript;
	public GameObject canvas2;

	bool flag=true;
	

	// Use this for initialization
	void Start () {
		gameOverText.SetActive(false);
		canvas2.SetActive(false);
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
			retryscript.Retry();
		}
		if (time < 0) time = 0;
		GetComponent<Text>().text = "TIME : " + ((int)time).ToString ();
	}
	void GameOver () {
		canvas2.SetActive(true);
		gameOverText.SetActive(true);
		playerScript.Stop2();
	}
}
