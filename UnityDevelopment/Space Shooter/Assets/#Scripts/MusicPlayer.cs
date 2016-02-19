using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;

	void Awake() {
		if (instance != null) {
			//an instance is created when whichever scene has uses this class. Then is
			//Destroy'd when another instance exists
			Destroy(gameObject); //Note: gameObject is the object calling this script
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
}
