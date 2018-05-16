using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
	 public bool isGoal = false;

	public float speed = 2.0f;
	public float slidspeed = 3;
	public float jumpHeight;
	public Text goalText;
	public Text scoreText; 
    public GameObject canvas2;

    RetryScript retryscript;    
	
    private Animator animator;
	private float defaultSpeed; //// 追加
    private float count = 0; //// 追加
	private float speedUpTimer = 0; //// 追加 スピードアップの残り時間を制御
    private float freezeTimer = 0;  //// 追加 フリーズの残り時間を制御
    int score = 0;


	// Use this for initialization
	void Start () {
		animator = GetComponent <Animator> ();
		defaultSpeed = speed; //// 追加
		goalText.enabled = false; // テキストを非表示にしておく
        animator.SetBool("RUN",true);
        canvas2.SetActive(false);
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
	public void Stop() {
        speed = 0;
        animator.SetBool("JUMP",false);
		animator.SetBool("RUN",false);
        animator.SetBool("IDLE",true);
    }
    public void Stop2(){
        speed = 0;
        animator.SetBool("JUMP",false);
        animator.SetBool("RUN",false);
        animator.SetBool("LOSE",true);
    }
	
    public void SpeedUp()
    {
        
        // スピードを1.5倍にアップ
        speed *= 1.2f;
        // 3秒後にスピードをもとに戻す
        StartCoroutine(DefaultSpeed(3));
    }

    
    private IEnumerator DefaultSpeed(float time)
    {
        // もしspeedUpTimerが0より大きければ，SpeedUp中ということで，
        // タイマーを初期化してからコルーチンを抜ける
        // 時間だけ伸ばすイメージ
        if (speedUpTimer <= 0)
        {
            speedUpTimer = time;
            yield break;
        }

        speedUpTimer = time;

        while (speedUpTimer > 0)
        {
            speedUpTimer -= Time.deltaTime;
            yield return null; // 1frame待つ
        }
        speed = defaultSpeed;
    }


    private void Freeze()
    {
        // Freezeさせる
        speed = 0;
        // n秒後にスピードをもとに戻す
        StartCoroutine(UnFreeze(1));
    }

    private IEnumerator UnFreeze(float time)
    {
        freezeTimer = time;

        // もしfreezeTimerが0より大きければ，freeze中ということで，
        // タイマーを初期化してからコルーチンを抜ける
        // 時間だけ伸ばすイメージ
        if (freezeTimer <= 0)
        {
            freezeTimer = time;
            yield break;
        }

        while (freezeTimer > 0)
        {
            freezeTimer -= Time.deltaTime;
            yield return null; // 1frame待つ
        }
        speed = defaultSpeed;
    }
   

    private void CountUp(int count)
    {
        this.count += count;
		scoreText.text = "SCORE:" + this.count; 
    }
    
	
	private void Goal()
	{
		goalText.enabled = true;
        canvas2.SetActive(true);
		Invoke("Stop",1); // 1秒後に止める	
        retryscript.Retry();
        //ランキング表示
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking (100);

	}
    void OnCollisionEnter(Collision other)
    {
		print(other.gameObject.tag);
        if (other.gameObject.CompareTag("Candy"))
        {
            // Candyというタグのオブジェクトにぶつかったら加速
            // ただしプレイヤーとキャンディーにColliderがアタッチされていて，IsTriggerのチェックが外れていること
            SpeedUp();
			Destroy(other.gameObject);
        }
		else if (other.gameObject.CompareTag("Goal"))
		{
			// ゴールの位置にゴールテープてきな感じで
            // ColliderがアタッチされているGoalタグのゴールを用意しておく
			isGoal = true;
            Goal();
		}
		else if (other.gameObject.CompareTag("Stone"))
        {
            // 石のタグをStoneにして，Colliderがアタッチされていて，IsTriggerのチェックが外れていること
            Freeze();
            // 石を消す
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Vegetable"))
        {
            // 野菜のタグをVecetableにして，Colliderがアタッチされていて，IsTriggerのチェックが外れていること
            // countを1増やす
            CountUp(1);
            // 野菜を消す
            Destroy(other.gameObject);
        }
        
    }
}
