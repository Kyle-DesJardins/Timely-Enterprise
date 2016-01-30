using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	private float dampening;

	void Start () {
		dampening = 0.10f;
	}

	void FixedUpdate () {
		transform.Translate(Input.GetAxis("Horizontal") * dampening, Input.GetAxis("Vertical") * dampening, 0);
	}
}
