using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	const int GAME_UNITS = 16;
	public float speed = 0;
	public float padding = 1f;

	float xmin;
	float xmax;

	// Use this for initialization
	void Start () {
		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
		Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));

		xmin = leftmost.x + padding;
		xmax = rightmost.x - padding;
	}
	
	// Update is called once per frame
	void Update () {
		//Movement
		if (Input.GetKey(KeyCode.LeftArrow)) {
			//transform.position += new Vector3(-speed * Time.deltaTime, 0,0);
			//OR
			transform.position += Vector3.left * speed * Time.deltaTime;
		} else if (Input.GetKey(KeyCode.RightArrow)) {
			//transform.position += new Vector3(speed * Time.deltaTime, 0,0);
			//OR
			transform.position += Vector3.right * speed * Time.deltaTime;
		}

		float newX = Mathf.Clamp(transform.position.x, xmin, xmax);
		transform.position = new Vector3(newX, transform.position.y, transform.position.z);

		//Shooting
		if (Input.GetKeyDown(KeyCode.Space)) {
			print ("Shot fired");
		}
	}
}
