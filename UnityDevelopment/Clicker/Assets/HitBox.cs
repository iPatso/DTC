using UnityEngine;
using System.Collections;

public class HitBox : MonoBehaviour {
	private HitPoints hp;

	// Use this for initialization
	void Start () {
		hp = GameObject.Find("HitPoints").GetComponent<HitPoints>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			hp.Attack(1f);
		}
	}
}
