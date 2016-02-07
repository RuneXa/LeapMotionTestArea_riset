using UnityEngine;
using System.Collections;
using Leap;

public class ToolPemukul : MonoBehaviour {

	Controller controller;
	Tool tool;
	int i;

	// Use this for initialization
	void Start () {
		controller = new Controller();
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = controller.Frame ();
		tool = frame.Tools.Frontmost;

		if (tool != Tool.Invalid) {
			Debug.Log ("ADA"+i);
		} else {
			Debug.Log("Nope");
		}
		i++;
	}
}
