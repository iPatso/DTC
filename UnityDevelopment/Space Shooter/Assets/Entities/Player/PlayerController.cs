using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public GameObject projectile;
	public float padding = 1f;
	public float speed = 15f;
	public float projectileSpeed = 15f;
	public float firingRate = 0.2f;
	public float health = 300f;

	public AudioClip fireSound;

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

	void Fire() {
		GameObject beam =  Instantiate(projectile, transform.position + new Vector3(0,0.5f,0), Quaternion.identity) as GameObject;
		beam.rigidbody2D.velocity = new Vector3(0, projectileSpeed, 0);
		AudioSource.PlayClipAtPoint(fireSound, transform.position);
	}

	// Update is called once per frame
	void Update () {
		//Shooting
		if (Input.GetKeyDown(KeyCode.Space)) {
			InvokeRepeating("Fire", 0.000001f, firingRate); 
		}
		if (Input.GetKeyUp(KeyCode.Space)) {
			CancelInvoke("Fire");
		}

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
	}

	//Collision (with projectile)
	void OnTriggerEnter2D(Collider2D collider) {
		Projectile missile = collider.gameObject.GetComponent<Projectile>();
		if (missile) {
			health -= missile.GetDamage();
			missile.Hit();
			if (health <= 0) {
				Die();
			}
		}
	}

	void Die() {
		LevelManager levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
		levelManager.LoadLevel("End");
		Destroy(gameObject);
	}

}
