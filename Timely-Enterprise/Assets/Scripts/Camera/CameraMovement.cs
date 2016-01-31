using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private Transform playerTransform;
	[SerializeField]
	private GameObject player;
	private float playerY;
	public bool moveUp;
	private float step;
	[SerializeField]
	private float speed;

	void awake() {
		moveUp = false;
		//step = 0f;
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

	void Update() {
		if(moveUp) {
			step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(transform.position.x, transform.position.y + 10.4f, transform.position.z), step);
		}
		if(playerTransform.position.y + 2.71f >= transform.position.y) {
			moveUp = false;
		}
	}
}
