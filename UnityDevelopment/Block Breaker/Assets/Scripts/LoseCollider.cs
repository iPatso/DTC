using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	
	public LevelManager levelManager; //Placed so can see in GUI

	//Should not be called because we are not using triggers
	void OnTriggerEnter2D (Collider2D trigger) {
		print ("Trigger");
		levelManager.LoadLevel("Win Screen");
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");
	}
}
