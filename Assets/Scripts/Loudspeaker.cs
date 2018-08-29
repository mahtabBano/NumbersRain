using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loudspeaker : MonoBehaviour {
//	public AudioClip[] d;
	int z; 
	float time;
	public string correctedAnswer;
	public static Loudspeaker instance;

	void Awake(){

		if (instance == null) {
			instance = this;
		}
		}

	void Start (){
		PlaySound ();

	}
	void Update(){
//		time -= Time.deltaTime;
//		if (time < 0) {
//			Invoke ("PlaySound", 2);
//			time = 2;
//		}
	}

	public void PlaySound(){
		z = Random.Range (0, 9);
		print (z);
		//AudioSource.PlayClipAtPoint (d [z], gameObject.transform.position);
		if(z==0){
			AudioCtrl.instance.Zero (gameObject.transform.position);
			correctedAnswer = "Zero";
		}
		if(z==1){
			AudioCtrl.instance.One (gameObject.transform.position);
			correctedAnswer = "One";
		}
		if(z==2){
			AudioCtrl.instance.Two (gameObject.transform.position);
			correctedAnswer = "Two";
		}
		if(z==3){
			AudioCtrl.instance.Three (gameObject.transform.position);
			correctedAnswer = "Three";
		}
		if(z==4){
			AudioCtrl.instance.Four (gameObject.transform.position);
			correctedAnswer = "Four";
		}
		if(z==5){
			AudioCtrl.instance.Five (gameObject.transform.position);
			correctedAnswer = "Five";
		}
		if(z==6){
			AudioCtrl.instance.Six (gameObject.transform.position);
			correctedAnswer = "Six";
		}
		if(z==7){
			AudioCtrl.instance.Seven (gameObject.transform.position);
			correctedAnswer = "Seven";
		}
		if(z==8){
			AudioCtrl.instance.Eith (gameObject.transform.position);
			correctedAnswer = "Eight";
		}
		if(z==9){
			AudioCtrl.instance.Nine (gameObject.transform.position);
			correctedAnswer = "Nine";
		}

	}

}