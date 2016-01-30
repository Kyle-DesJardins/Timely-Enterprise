using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private Transform playerTransform;
	[SerializeField]
	private GameObject player;
	private float playerY;

	void awake() {
		if (player != null) {
			playerTransform = player.GetComponent<Transform>();
			playerY = playerTransform.position.y + 2.71f;
		}
	}

	void FixedUpdate () {
		if (player != null) {
			playerTransform = player.GetComponent<Transform>();
			transform.position = new Vector2(playerTransform.position.x, playerY);
		}
	}
}
