using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public AudioClip callSound;

	private AudioSource audioSource;
	private bool called = false;
	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		rigidbody = GetComponent<Rigidbody>();
	}

	public void Call() {
		if (!called) {
			called = true;
			Debug.Log("Helicopter called");
			audioSource.clip = callSound;
			audioSource.Play();
			rigidbody.velocity = new Vector3(0, 0, 50f);
		}
	}
}
