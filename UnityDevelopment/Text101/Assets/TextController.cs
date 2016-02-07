using UnityEngine;
using UnityEngine.UI; //need b/c Text
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			text.text = "You wake up in a proson cell and you need to escape. There are sheets on the bed, " +
						"poop in the toilet, and broken glass near the sink. The door is locked from the " +
						"outside. Bummer.\n\n" +
						"Press V to view sheets,"
		}
	}
}
