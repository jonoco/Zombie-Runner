using UnityEngine;
using System.Collections;

public class Daycycle : MonoBehaviour {

	[Range (60, 600)]
	public float secondsPerDay = 60;
	public bool progressTime = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (progressTime) {
			float rotationSpeed = Time.deltaTime / secondsPerDay * 360;
			transform.Rotate(rotationSpeed,0,0);
		}
	}
}
