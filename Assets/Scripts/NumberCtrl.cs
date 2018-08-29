using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCtrl : MonoBehaviour {
	
	public static NumberCtrl instance;

	void Awake(){
		if(instance==null){
			instance = this;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag("Player")  ) {
			Destroy (gameObject);
			 
			if(Loudspeaker.instance.correctedAnswer==gameObject.tag){
				
				GameCtrl.instance.UpdateScoreCount ();
				SFXCtrl.instance.CorrectAnswer (GameCtrl.instance.correctAns.position);

			Loudspeaker.instance.PlaySound ();
			}

			else 
				
				GameCtrl.instance.GameOver ();	
		
	}
		if (other.gameObject.CompareTag ("Ground") && Loudspeaker.instance.correctedAnswer==gameObject.tag) {
			
			GameCtrl.instance.DecreaseScoreCount ();
		}

}
}