using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {
	 
	void Awake(){
		
	GameObject[] objs= GameObject.FindGameObjectsWithTag("music");
		if (objs.Length > 1)
			Destroy (this.gameObject);
		
			DontDestroyOnLoad(this.gameObject);

}
	void Update(){
		if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex == 1) {
			gameObject.GetComponent<AudioSource> ().mute = true;
		} else {
			gameObject.GetComponent<AudioSource> ().mute = false;
	
		}
	}
}