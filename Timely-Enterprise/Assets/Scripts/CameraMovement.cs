using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private Transform playerTransform;
	[SerializeField]
	private GameObject player;

	void awake() {
	}

	void FixedUpdate () {
		if (player != null) {
			playerTransform = player.GetComponent<Transform>();
			transform.position = new Vector2(playerTransform.position.x, playerTransform.position.y);
		}
	}
}
