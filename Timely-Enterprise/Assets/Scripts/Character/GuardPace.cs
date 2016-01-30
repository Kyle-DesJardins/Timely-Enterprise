using UnityEngine;
using System.Collections;

public class GuardPace : MonoBehaviour {

	[SerializeField]
	private float walk;
	[SerializeField]
	private float run;
	private bool turned;

	void Start () {
		turned = false;
		Physics2D.IgnoreCollision(GetComponent<Collider2D>(), GetComponent<Collider2D>());
	}

	void FixedUpdate () {

//		if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
//			run = 0.25f;
//		}
//		else {
//			run = 0.1f;
//		}

		transform.Translate(run, 0, 0);
		Debug.Log(turned);

		if(transform.position.x >= 10.8f && turned == false) {
			transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			turned = true;
		}
		else if (transform.position.x <= -8.38f && turned == true) {
			transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			turned = false;
		}
	}
}
