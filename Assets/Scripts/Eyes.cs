using UnityEngine;
using System.Collections;

public class Eyes : MonoBehaviour {

	private Camera eyes;
	private float defaultFOV;

	// Use this for initialization
	void Start () {
		eyes = GetComponent<Camera>();
		defaultFOV = eyes.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Zoom")) { ZoomIn();} 
		else { ZoomOut(); }
	}

	void ZoomIn() {
		eyes.fieldOfView = defaultFOV/2;
	}

	void ZoomOut() {
		eyes.fieldOfView = defaultFOV;
	}
}
