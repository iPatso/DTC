using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HitPoints : MonoBehaviour {
	public float hp = 10f;

	private Text hpText;

	public void Attack(float damage) {
		hp -= damage;
		hpText.text = hp.ToString();
	}

	// Use this for initialization
	void Start () {
		hpText = GetComponent<Text>();
		hpText.text = hp.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
