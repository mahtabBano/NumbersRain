using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXCtrl : MonoBehaviour {

	public SFX sfx;
	public static SFXCtrl instance;

	public void Awake(){
		if(instance==null){
			instance = this;
		}
	}

	public void CorrectAnswer(Vector3 pos){
		Instantiate (sfx.correctAns,pos,Quaternion.identity);
	}
	public void Player_lands_fx(Vector3 pos){
		Instantiate (sfx.player_lands_fx,pos,Quaternion.identity);
	}
	public void Gift_fx(Vector3 pos){
		Instantiate (sfx.fxGift,pos,Quaternion.identity);
	}
	public void HighScore(Vector3 pos){
		Instantiate (sfx.highScore,pos,Quaternion.identity);
	}
}
