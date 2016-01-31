using UnityEngine;
using System.Collections;

public class InteractFunctionality : MonoBehaviour {

    [SerializeField]
    private string customKeyCode;

    [HideInInspector]
    public string interactableTag;

    [SerializeField]
	private bool interacte;
	private bool animate;
	private Renderer render;
	private Collider2D collider;
	private Rigidbody2D rigidbody;
    [SerializeField]
	private Collider2D animateCollider;
	private float teleporting;
	private GameObject camera;
	private float speed = 1;

	private bool animating;
	private float animTimer;

	void Awake() {
		interacte = false;
		render = gameObject.GetComponent<Renderer>();
		collider = gameObject.GetComponent<Collider2D>();
		rigidbody = gameObject.GetComponent<Rigidbody2D>();
		animating = false;
        camera = GameObject.Find("Main Camera");
        //smooth = 0;
    }

    void Update()
    {
		interactableTag = (animateCollider.gameObject.tag);
		if (Input.GetKeyDown(customKeyCode) && interacte == true && ((interactableTag == "Door")))
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

		if((interactableTag == "Stair") && interacte == true && Input.GetKeyDown(customKeyCode) && !camera.GetComponent<CameraMovement>().moveUp) {
            if (animateCollider.gameObject.GetComponent<StairProperties>().getBottom())
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 10.4f, transform.position.z);
                camera.GetComponent<CameraMovement>().setTargetMovement(true);
                camera.GetComponent<CameraMovement>().moveUp = true;
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 10.4f, transform.position.z);
                camera.GetComponent<CameraMovement>().setTargetMovement(false);
                camera.GetComponent<CameraMovement>().moveUp = true;
            }
		}
    }

    public void SetInteracteToPositive()
    {
        interacte = true;
    }


	void OnTriggerEnter2D(Collider2D col) {
		interacte = true;
		animateCollider = col;
	}

	void OnTriggerExit2D(Collider2D col) {
		interacte = false;
	}
}
