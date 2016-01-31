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
	private float speed = 5f;
    private Vector3 targetMovement;
    private Vector3 pastPosition;
    [SerializeField]
    private float heightChange = 8.4f;

	void awake() {
		moveUp = false;
		//step = 0f;
		if (player != null) {
			playerTransform = player.GetComponent<Transform>();
			playerY = playerTransform.position.y + 2.68f;
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 2.68f, player.transform.position.z);
		}
	}

	void FixedUpdate () {
		if (player != null && !moveUp) {
			playerTransform = player.GetComponent<Transform>();
			transform.position = new Vector2(playerTransform.position.x, transform.position.y);
		}
	}

	void Update() {
        if (moveUp) {
            Debug.Log("Move up" + moveUp);
			step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, targetMovement, step);
            if (transform.position.y >= pastPosition.y + heightChange)
            {
                player.GetComponent<InteractFunctionality>().SetInteracteToPositive();
                moveUp = false;
            }
            else if(transform.position.y <= pastPosition.y - heightChange)
            {
                player.GetComponent<InteractFunctionality>().SetInteracteToPositive();
                moveUp = false;
            }
		}
	}

    public void setTargetMovement(bool bottom)
    {
        if(bottom)
        {
            targetMovement = transform.position + new Vector3(0, heightChange, 0);
            pastPosition = transform.position;
        }
        else
        {
            targetMovement = transform.position - new Vector3(0, heightChange, 0);
            pastPosition = transform.position;
        }
    }
}
