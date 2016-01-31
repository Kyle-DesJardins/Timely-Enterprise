using UnityEngine;
using System.Collections;

public class PlayerController: MonoBehaviour {

	private float dampening;
	[SerializeField]
	private float jump;
	private bool jumped;
	private float jumpTimer;
	private Rigidbody2D rigidbody;
	private Renderer render;

	void Start () {
		render = gameObject.GetComponent<Renderer>();
		jumped = false;
		jumpTimer = 2.1f;
		rigidbody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {

		if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
			dampening = 0.25f;
		}
		else {
			dampening = 0.1f;
		}

		if(Input.GetAxis("Vertical") > 0 && jumped == false) {
			Debug.Log("Yes");
			rigidbody.AddForce(new Vector2(0f, jump), ForceMode2D.Force);
			jumped = true;
			jumpTimer = 0;
		}
		else if(render.enabled) {
			if(Input.GetAxis("Horizontal") > 0) {
				transform.rotation = Quaternion.Euler(0, 180, 0);
				transform.Translate(Input.GetAxis("Horizontal") * -dampening, 0, 0);
			}
			else {
				transform.rotation = Quaternion.Euler(0, 0, 0);
				transform.Translate(Input.GetAxis("Horizontal") * dampening, 0, 0);
			}
		}

		if(jumped == true) {
			jumpTimer += Time.deltaTime;
			if (jumpTimer >= 2) {
				jumped = false;
			}
		}
	}
}
