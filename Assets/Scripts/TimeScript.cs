using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class TimeScript : MonoBehaviour {
	private float time = 60;
    public PlayerScript playerScript;
	
	public GameObject gameOverText; 

	bool flag=true;
	

	// Use this for initialization
	void Start () {
		gameOverText.SetActive(false);
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
		playerScript.Stop();
	}
}
