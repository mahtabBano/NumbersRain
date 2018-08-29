using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PazPanelCtrl : MonoBehaviour {
	public GameObject panel;
	public static PazPanelCtrl instance;

	void Awake(){
		if (instance == null)
			instance = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void ActivePanel(){
		
		panel.SetActive ( true);
		Time.timeScale = 0;
		Camera.main.GetComponentInChildren<AudioSource> ().enabled = false;
	}
	public void DeActivePanel(){

		panel.SetActive (false);
		Time.timeScale = 1;
		Camera.main.GetComponentInChildren<AudioSource> ().enabled = true;
	}
}
