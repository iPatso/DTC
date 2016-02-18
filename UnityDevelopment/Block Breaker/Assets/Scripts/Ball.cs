using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	const int GAME_UNITS = 16;

	private Paddle paddle;
	private Vector3 paddleToBallVector;

	private bool hasStarted = false;
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 ballPos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
		float posInBlocks = ballPos.x / Screen.width * GAME_UNITS;	
		ballPos.x = Mathf.Clamp(posInBlocks, 0.5f, 15.5f);

		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;

			//Launch ball on click
			if (Input.GetMouseButtonDown(0)) {
				print ("Mouse clicked, launched ball");
				hasStarted = true;

				this.rigidbody2D.velocity = new Vector2 (2f, 10f);
			}
		}
	}

	void OnCollisionEnter2D (Collision2D collision) {
		Vector2 tweak = new Vector2(Random.Range (0f, 0.5f), Random.Range(0f, 0.5f));

		if (hasStarted) {
			audio.Play();
			rigidbody2D.velocity += tweak;
		}
	}
}
