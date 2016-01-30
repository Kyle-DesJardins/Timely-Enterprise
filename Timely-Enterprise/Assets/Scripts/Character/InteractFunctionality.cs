using UnityEngine;
using System.Collections;

public class InteractFunctionality : MonoBehaviour {

    [SerializeField]
    private string customKeyCode;

    [HideInInspector]
    public string interactableTag;

	private bool interacte;
	private bool animate;
	private Renderer render;
	private Collider2D collider;
	private Rigidbody2D rigidbody;
	private Collider2D animateCollider;

	private bool animating;
	private float animTimer;

	void Awake() {
		interacte = false;
		render = gameObject.GetComponent<Renderer>();
		collider = gameObject.GetComponent<Collider2D>();
		rigidbody = gameObject.GetComponent<Rigidbody2D>();
		animating = false;
	}

    void Update()
    {
        if (Input.GetKeyDown(customKeyCode) && interacte == true)
        {
            Debug.Log(transform.name + animateCollider + " Interact");
			animating = true;
			animateCollider.GetComponent<Animator>().SetInteger("Open", 1);
		}

		if(animating == true) {
			animTimer += Time.deltaTime;
			if (animTimer >= 0.85f) {
				if(render.enabled) {
					render.enabled = false;
					collider.enabled = false;
					rigidbody.isKinematic = true;
				}
				else if (!render.enabled) {
					render.enabled = true;
					collider.enabled = true;
					rigidbody.isKinematic = false;
					animating = true;
				}
				animating = false;
				animTimer = 0;
				animateCollider.GetComponent<Animator>().SetInteger("Open", 0);
			}
		}
    }


	void OnTriggerEnter2D(Collider2D col) {
		interacte = true;
		animateCollider = col;
	}

	void OnTriggerExit2D(Collider2D col) {
		interacte = false;
	}
}
