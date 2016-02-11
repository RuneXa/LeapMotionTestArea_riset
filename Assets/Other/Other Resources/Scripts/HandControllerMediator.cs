using UnityEngine;
using System.Collections;

public class HandControllerMediator : MonoBehaviour {

	[Header ("Controller")]
	[SerializeField] GameObject handControllerObj;
	HandController handController;

	[Header("Tool Model")]
	[SerializeField] GameObject toolForHand;


	void Start () {
		handController = handControllerObj.GetComponent<HandController> ();
		handController.toolModel = toolForHand.GetComponent<ToolModel> ();
	}

	public GameObject getToolObj(){
		return toolForHand;
	}

}
