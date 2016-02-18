using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public Sprite[] hitSprites;
	public static int breakableCount = 0;
	public AudioClip crack;

	private int timesHit;
	private LevelManager levelManager;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
		isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			breakableCount++;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D collision) {
		AudioSource.PlayClipAtPoint(crack, transform.position, 0.25f);
		if (isBreakable) {
			HandleHits();
			print (breakableCount);
		}
	}

	void HandleHits() {
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits) {
			breakableCount--;
			levelManager.BrickDestroyed();
			Destroy(gameObject);
		} else {
			LoadSprites();
		}
	}

	void LoadSprites() {
		int spriteIndex = timesHit - 1;
		if (hitSprites[spriteIndex]) {
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}

	// TODO Remove this method once we can actually win
	void SimulateWin() {
		levelManager.LoadNextLevel();
	}
}
