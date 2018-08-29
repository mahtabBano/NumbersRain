using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;//RSFB
using System.IO;


public class GameCtrl : MonoBehaviour {
	
	public GameObject panel;
	public static GameCtrl instance;
	public int lifeTimeScore;
	int x;
	public UI ui;
	public GameData data;
	string dataFilePath;
	BinaryFormatter bf;
	public GameObject basket;
	public GameObject btnPaz;
	public bool isGameOver;
	public Transform starFX;
	public Transform correctAns;

	// Use this for initialization


	void Awake(){
		if (instance == null) {
			instance = this;
		}

		bf = new BinaryFormatter ();
		dataFilePath = Application.persistentDataPath + "/game.bat";
	}

	void Start () {
		//lifeTime = MaxTime;
		//anim=GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			ResetData ();
		}
		if(lifeTimeScore>data.bestScore){
			data.bestScore = lifeTimeScore;
			ui.bestScoreText.text = "" + data.bestScore;
		}


	}
	void SaveData(){
		FileStream fs = new FileStream (dataFilePath, FileMode.Create);
		bf.Serialize (fs,data);
		fs.Close();
	}
	void LoadData(){
		if (File.Exists (dataFilePath)) {
			FileStream fs = new FileStream (dataFilePath, FileMode.Open);
			data = (GameData)bf.Deserialize (fs);
			ui.bestScoreText.text = "" + data.bestScore;
			fs.Close();
		}
	}
	void ResetData(){
		FileStream fs = new FileStream (dataFilePath, FileMode.Create);
		bf.Serialize (fs,data);
		data.bestScore = 0;
		ui.finalScore.text = ":" + data.score;
		ui.bestScoreText.text = ":" + data.bestScore;
		fs.Close();
	}
	void OnEnable(){
		LoadData ();
	} 
	void OnDisable(){
		SaveData ();
	}

	public void GameOver(){
		AudioCtrl.instance.GameOver (gameObject.transform.position);

		ui.finalScore.text = "" + lifeTimeScore;
		isGameOver = true;
		panel.SetActive (true);
		SpawnNumber.instance.isCreate = false;
		SpawnNumber.instance.canSpawn = false;
		Camera.main.GetComponentInChildren <AudioSource> ().enabled = false;
	    Timer.instanse.isGameOver = true;
		basket.GetComponent<basketCtrl> ().enabled = false;
		PazPanelCtrl.instance.DeActivePanel();
		Time.timeScale = 0;


	}

	public void UpdateScoreCount(){
		
		lifeTimeScore +=1;

		ui.scoreTxt.text = " " +lifeTimeScore;
		AudioCtrl.instance.CorrectAnswer (gameObject.transform.position);
		SFXCtrl.instance.HighScore (starFX.position);


	}
	public void DecreaseScoreCount(){
		if(lifeTimeScore>0){
		lifeTimeScore -=1;
		ui.scoreTxt.text = " " +lifeTimeScore;
		AudioCtrl.instance.RunawayAnswer (gameObject.transform.position);
		} else {
			GameOver ();
		}

	}

			
	public void UpdateScoreByGift(){
		
		lifeTimeScore +=10;

		ui.scoreTxt.text = " " +lifeTimeScore;
		AudioCtrl.instance.CorrectAnswer (gameObject.transform.position);
		SFXCtrl.instance.HighScore (starFX.position);
	}		
		

}
