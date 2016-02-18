using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	
	private LevelManager levelManager;

	//Should not be called because we are not using triggers
	void OnTriggerEnter2D (Collider2D trigger) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		levelManager.LoadLevel("Lose Screen");
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");
	}
}
