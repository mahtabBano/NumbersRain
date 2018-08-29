using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNumber : MonoBehaviour {
	public static SpawnNumber instance;


	
	public GameObject[] numbers;
	public GameObject[] gift;
	public Transform[] pos;
	public Transform [] pos1;
	public Transform [] pos2;

	int y,x,w,z,zPos;

	public float time;
	public bool isCreate;

	public float spawnTime;
	public bool canSpawn;

	void Awake(){
		if (instance == null) {
			instance = this;
		}
		z = Random.Range (0, gift.Length);
		zPos = Random.Range (0, pos2.Length);
	}

	// Use this for initialization
	void Start () {
		y = Random.Range (0, numbers.Length);
		x = Random.Range (0, pos.Length);
		w = Random.Range (0, pos.Length);

		isCreate = true;
		canSpawn = false;
		Invoke ("TurnTrueSpawn",5);
		///CreatNumber ();
		//InvokeRepeating("CreatNumber",1,1);
	}
	
	// Update is called once per frame
	void Update () {
		
		time -= Time.deltaTime;
		if (time < 0) {
			Invoke ("CreatNumber", 2);
			time = 2;
			y = Random.Range (0, numbers.Length);
			x=Random.Range (0, pos.Length);
			w=Random.Range (0, pos.Length);
			//z = Random.Range (0, gift.Length-1);
			//zPos = Random.Range (0, pos.Length-1);

		}
		if(canSpawn){
			StartCoroutine ("SpawnGift");
		}
	}

	void TurnTrueSpawn(){
		canSpawn = true;
	}

	public void CreatNumber(){
		if (isCreate) {
			
			
			switch(Loudspeaker.instance.correctedAnswer){

			case "Zero":
				Instantiate (numbers [y], pos [x].position, Quaternion.identity);
				Instantiate (numbers [0], pos1 [w].position, Quaternion.identity);
				break;
			case "One":
				Instantiate (numbers [y], pos [x].position, Quaternion.identity);
				Instantiate (numbers [1], pos1 [w].position, Quaternion.identity);				
				break;
			case "Two":
				Instantiate (numbers [y], pos [x].position, Quaternion.identity);
				Instantiate (numbers [2], pos1 [w].position, Quaternion.identity);
				break;
			case "Three":
				Instantiate (numbers [y], pos [x].position, Quaternion.identity);
				Instantiate (numbers [3], pos1 [w].position, Quaternion.identity);
				break;
			case "Four":
				Instantiate (numbers [y], pos [x].position, Quaternion.identity);
				Instantiate (numbers [4], pos1 [w].position, Quaternion.identity);
				break;
			case "Five":
				Instantiate (numbers [y], pos [x].position, Quaternion.identity);
				Instantiate (numbers [5], pos1 [w].position, Quaternion.identity);
				break;
			case "Six":
				Instantiate (numbers [y], pos [x].position, Quaternion.identity);
				Instantiate (numbers [6], pos1 [w].position, Quaternion.identity);
				break;
			case "Seven":
				Instantiate (numbers [y], pos [x].position, Quaternion.identity);
				Instantiate (numbers [7], pos1 [w].position, Quaternion.identity);
				break;
			case "Eight":
				Instantiate (numbers [y], pos [x].position, Quaternion.identity);
				Instantiate (numbers [8], pos1 [w].position, Quaternion.identity);
				break;
			case "Nine":
				Instantiate (numbers [y], pos [x].position, Quaternion.identity);
				Instantiate (numbers [9], pos1 [w].position, Quaternion.identity);
				break;
			}

		}
			
	}


	IEnumerator SpawnGift(){
		Instantiate (gift[z],pos2[zPos].position,Quaternion.identity);
		canSpawn = false;
		yield return new WaitForSeconds (spawnTime);
		canSpawn = true;
	}

}
