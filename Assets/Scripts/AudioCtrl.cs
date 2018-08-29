using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCtrl : MonoBehaviour {

	public static AudioCtrl instance;
	public PlayerAudio playerAudio;
	//public Transform loudspeaker;
	//public Vector3 pos;

	[Tooltip("use to on/off the audio of game form inspactor")]
	public static bool soundOn;


	// Use this for initialization
	void Awake () {
		if(instance==null){
			instance = this;
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Zero(Vector3 pos){
		
			AudioSource.PlayClipAtPoint (playerAudio.zero, pos,1);

	}
	public void One(Vector3 pos){
		
			AudioSource.PlayClipAtPoint (playerAudio.one, pos,1);
	}
	public void Two(Vector3 pos){
		
			AudioSource.PlayClipAtPoint (playerAudio.two, pos,1);
	}
	public void Three(Vector3 pos){
		
			AudioSource.PlayClipAtPoint (playerAudio.three, pos,1);
	}
	public void Four(Vector3 pos){
		
			AudioSource.PlayClipAtPoint (playerAudio.four, pos,1);
	}
	public void Five(Vector3 pos){

		AudioSource.PlayClipAtPoint (playerAudio.five, pos,1);
	}
	public void Six(Vector3 pos){

		AudioSource.PlayClipAtPoint (playerAudio.six, pos,1);
	}
	public void Seven(Vector3 pos){

		AudioSource.PlayClipAtPoint (playerAudio.seven, pos,1);
	}
	public void Eith(Vector3 pos){

		AudioSource.PlayClipAtPoint (playerAudio.eith, pos,1);
	}
	public void Nine(Vector3 pos){

		AudioSource.PlayClipAtPoint (playerAudio.nine, pos,1);
	}
	//public void Start(Vector3 pos){

	//	AudioSource.PlayClipAtPoint (playerAudio.Start, pos,1);
	//}
	public void GameOver(Vector3 pos){

		AudioSource.PlayClipAtPoint (playerAudio.GameOver, pos,1);
	}
	public void CorrectAnswer(Vector3 pos){

		AudioSource.PlayClipAtPoint (playerAudio.correctAnswer, pos,1);
	}
	public void RunawayAnswer(Vector3 pos){

		AudioSource.PlayClipAtPoint (playerAudio.runawayAnswer, pos,1);
	}
	public void ButoonClickOn(Vector3 pos){

		AudioSource.PlayClipAtPoint (playerAudio.buttonClickOn, pos,1);
	}


}
