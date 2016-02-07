using UnityEngine;
using System.Collections;
using Leap;

public class GestureHands : MonoBehaviour {
	Controller controller;

	// Use this for initialization
	void Start () {
		controller = new Controller();
		controller.EnableGesture (Gesture.GestureType.TYPESWIPE);
		controller.Config.SetFloat ("Gesture.Swipe.MinLength", 200.0f);
		controller.Config.SetFloat ("Gesture.Swipe.MinVelocity", 750f);
		controller.Config.Save();
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = controller.Frame();
		GestureList gestures = frame.Gestures ();

		for(int i=0;i<gestures.Count;i++) {
			Gesture g = gestures [i];
			if (g.Type == Gesture.GestureType.TYPE_SWIPE) {
				SwipeGesture s = new SwipeGesture (g);
				Vector swipeDirection = s.Direction;
				if (swipeDirection.x < 0) {
					Debug.Log ("Left");

				}else if(swipeDirection.x > 0) {
					Debug.Log("Right");
				}
			}

		}
	}

}