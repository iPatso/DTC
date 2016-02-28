using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	
	public AudioClip startClip;
	public AudioClip gameClip;
	public AudioClip endClip;

	private AudioSource music;

	void Awake() {
		if (instance != null) {
			//an instance is created when whichever scene has uses this class. Then is
			//Destroy'd when another instance exists
			Destroy(gameObject); //Note: gameObject is the object calling this script
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
			music = GetComponent<AudioSource>();
		}
	}

	void OnLevelWasLoaded(int level) {
		print ("MusicPlayer: Loaded level " + level);
		music.Stop ();

		if (level == 0) {
			music.clip = startClip;
		} else if (level == 1) {
			music.clip = gameClip;
		} else if (level == 2) {
			music.clip = endClip;
		}
		music.loop = true;
		music.Play();
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
}
