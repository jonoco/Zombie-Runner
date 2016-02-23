using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	public Helicopter helicopter;
	public GameObject landingArea;

	private bool willRespawn = false;
	private List<Vector3> spawnPoints = new List<Vector3>();

	void Start () {
		Transform[] spawnPointTransforms = GameObject.Find("Player Spawn Point").GetComponentsInChildren<Transform>();

		foreach (Transform spawnPoint in spawnPointTransforms) {
			if (spawnPoint.transform.position.y > 0) {
				spawnPoints.Add(spawnPoint.transform.position);
			}
		}
	}

	void Update() {
		if (willRespawn) {
			willRespawn = false;
			Respawn();
		}
	}

	void Respawn() {
		int randomIndex = Random.Range(0, spawnPoints.Count);
		Vector3 randomSpawnPoint = spawnPoints[randomIndex];

		transform.position = randomSpawnPoint;
	}

	void OnFindClearArea() {
		Debug.Log("Found clear area on player");
		helicopter.Call();
		Invoke("CreateLandingArea", 3f);
	}

	void CreateLandingArea() {
		Instantiate(landingArea, transform.position, transform.rotation);
	}
}
