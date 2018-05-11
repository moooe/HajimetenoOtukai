using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class TimeScript : MonoBehaviour {
	private float time = 60;
    public PlayerScript playerScript;
	
	public GameObject gameOverText; 
	

	// Use this for initialization
	void Start () {
		gameOverText.SetActive(false);
		GetComponent<Text>().text = "TIME : " + ((int)time).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		//// ここから
        if (playerScript.isGoal) // もしPlayerScriptのisGoalがTrueだったら
        {
            return; // これより下は見ない
        }
        //// ここまで追加
		time -= Time.deltaTime;
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
