using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {
	public GameObject player;
	basketCtrl basketCTRL;
	// Use this for initialization
	void Start () {
		basketCTRL = player.GetComponent<basketCtrl> ();
	}

	public void MoveLeft(){
		basketCTRL.MoveLeft ();
	}
	public void MoveRight(){
		basketCTRL.MoveRight ();
	}
	public void StopMovingPlayer(){
		basketCTRL.StopMovingPlayer ();
	}

}
