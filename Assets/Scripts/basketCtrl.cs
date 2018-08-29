using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketCtrl : MonoBehaviour {


	Rigidbody2D rigid;
	public float boostSpeed;
	Vector3 pos;
	public Transform posB;
	public Transform posGiftFX;
	public bool isMoveLeft;
	public bool isMoveRight;
	// Use this for initialization
	void Start () {
		rigid = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameCtrl.instance.isGameOver) {
			gameObject.tag="Untagged";
		}
		pos = transform.position;
		pos.x = Mathf.Clamp (transform.position.x,-3.2f,3.2f);
		transform.position = pos;
		float basketSpeed = Input.GetAxisRaw ("Horizontal");
		basketSpeed *= boostSpeed;

		if (basketSpeed != 0) {
			MoveHorizontal (basketSpeed);    
		} else {
			StopMoving ();
		}
		if (isMoveLeft)
			MoveHorizontal (-boostSpeed);
		else if (isMoveRight) {
			MoveHorizontal (boostSpeed);
		}

	}
	void MoveHorizontal (float speed){
		rigid.velocity = new Vector2 (speed, rigid.velocity.y);

}
	void StopMoving (){
		rigid.velocity = new Vector2 (0,rigid.velocity.y);
	}

		
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.CompareTag("Ground")){
			SFXCtrl.instance.Player_lands_fx (posB.position);

		}
		
	}
	public void MoveLeft(){
		isMoveLeft = true;
	}
	public void MoveRight(){
		isMoveRight = true;
	} 

	public void StopMovingPlayer(){
		isMoveLeft = false;
		isMoveRight = false;
		StopMoving ();
	} 
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Gift") {
			GameCtrl.instance.UpdateScoreByGift ();
			SFXCtrl.instance.Gift_fx (posGiftFX.position);

		}
	}

}