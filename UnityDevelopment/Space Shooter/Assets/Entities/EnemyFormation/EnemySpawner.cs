using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject enemyPrefab;
	public float speed = 3f;
	public float width = 10f;
	public float height = 5f;
	public float padding = 1f;
	public float spawnDelay = 0.5f;
	
	float xmin;
	float xmax;
	Vector3 xDirection = Vector3.right;

	public void OnDrawGizmos() {
		Gizmos.DrawWireCube(transform.position, new Vector3(width,height));
	}

	void SpawnEnemies() {
		//Spawn enemies in "Position" objects
		foreach (Transform child in transform) {
			GameObject enemy = Instantiate(enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = child;
		}
	}


	void SpawnUntilFull() {
		Transform freePosition = NextFreePosition();
		if (freePosition) {
			GameObject enemy = Instantiate(enemyPrefab, freePosition.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = freePosition;
		}
		if (NextFreePosition()) {
			Invoke("SpawnUntilFull", spawnDelay);
		}
	}

	// Use this for initialization
	void Start () {
		SpawnUntilFull();

		//Set min and max for x
		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftBoundary = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
		Vector3 rightBoundary = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));

		padding = width/2f;
		xmin = leftBoundary.x + padding;
		xmax = rightBoundary.x - padding;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x >= xmax)
			xDirection = Vector3.left;
		if (transform.position.x <= xmin)
			xDirection = Vector3.right;

		transform.position += xDirection * speed * Time.deltaTime;

		if (AllMembersDead()) {
			SpawnUntilFull();
		}
	}

	Transform NextFreePosition() {
		foreach (Transform childPositionGameObject in transform ) {
			if (childPositionGameObject.childCount == 0)
				return childPositionGameObject;
		}
		return null;
	}

	bool AllMembersDead() {
		foreach (Transform childPositionGameObject in transform ) {
			if (childPositionGameObject.childCount > 0)
				return false;
		}
		return true;
	}
}
