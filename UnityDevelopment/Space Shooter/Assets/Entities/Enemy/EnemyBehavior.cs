using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {
	public GameObject projectile;
	public float projectileSpeed = 10f;
	public float shotsPerSecond = 0.5f;
	public float health = 500f;
	public int scoreValue = 150;

	public AudioClip fireSound;
	public AudioClip deathSound;

	private ScoreKeeper scoreKeeper;

	void Start() {
		scoreKeeper = GameObject.Find("ScoreKeeper").GetComponent<ScoreKeeper>();
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Projectile missile = collider.gameObject.GetComponent<Projectile>();
		if (missile) {
			health -= missile.GetDamage();
			missile.Hit();
			if (health <= 0) {
				Die ();
			}
		}
	}

	void Die() {
		AudioSource.PlayClipAtPoint(deathSound, transform.position);
		Destroy(gameObject);
		scoreKeeper.Score(scoreValue);
	}

	void Update() {
		float probability = shotsPerSecond * Time.deltaTime;
		if (Random.value < probability)
			Fire ();
	}
	
	void Fire() {
		GameObject beam =  Instantiate(projectile, transform.position + new Vector3(0,-0.5f,0), Quaternion.identity) as GameObject;
		beam.rigidbody2D.velocity = new Vector3(0, -projectileSpeed, 0);
		AudioSource.PlayClipAtPoint(fireSound, transform.position);
	}
}
