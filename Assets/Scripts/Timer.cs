using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text timerText;
	private float startTime;
	public bool isGameOver;

	public static Timer instanse;

	void Awake(){
		if (instanse == null) {
			instanse = this;
		}
	}

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		isGameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isGameOver) {
			float t = Time.time - startTime;
			string minutes = ((int)t / 60).ToString ();
			string secunds = (t % 60).ToString ("f0");
			timerText.text = minutes + " : " + secunds;
		}
	}


		

}
